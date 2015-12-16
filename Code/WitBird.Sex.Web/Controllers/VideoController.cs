using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WitBird.Sex.BLL;
using WitBird.Sex.Web.Models;

namespace WitBird.Sex.Web.Controllers
{
    public class VideoController : BaseController
    {
        /// <summary>
        /// 视频首页
        /// </summary>
        public ActionResult Index(string page)
        {
            this.Internationalization();

            VideoModel model = new VideoModel();

            if (string.IsNullOrEmpty(page))
            {
                page = "1";
            }

            VideoService videoService = new VideoService();
            model.Page = Int32.Parse(page);

            model.PageSize = 20;//每页显示20张
            model.PageIndex = Int32.Parse(page);
            int count = 0;
            //视频列表
            model.Videos = videoService.GetVideos(null, model.PageSize, model.PageIndex, out count);
            //分页
            if (model.Videos != null && model.Videos.Count > 0)
            { 
                model.PageStep = 10; //页码10个
                model.AllCount = count;
                if (model.AllCount % model.PageSize == 0)
                {
                    model.PageCount = model.AllCount / model.PageSize;
                }
                else
                {
                    model.PageCount = model.AllCount / model.PageSize + 1;
                }
            }

            CategoryService categoryService = new CategoryService();
            model.Category = categoryService.GetCategoryById("video");

            return View(model);
        }

        /// <summary>
        /// 播放视频
        /// </summary>
        public ActionResult Play(string id)
        {
            this.Internationalization();
            VideoModel model = new VideoModel();

            if (string.IsNullOrEmpty(id))
            {
                id = "1";
            }

            VideoService videoService = new VideoService();
            model.Video = videoService.GetVideoById(Int32.Parse(id));

            //随机推荐
            model.RecommendRandoms = videoService.GetRecommendRandom(6);

            //猜你喜欢
            model.Like = videoService.GetLike(12);

            //推荐新闻
            model.RecommendNews = NewsService.GetRecommendRandom(10);

            //推荐小说
            model.RecommendNovels = NovelService.GetRecommendRandom(10);

            return View(model);
        }
    }
}
