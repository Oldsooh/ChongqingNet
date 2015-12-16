using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WitBird.Sex.BLL;
using WitBird.Sex.Model;
using WitBird.Sex.Web.Models;

namespace WitBird.Sex.Web.Controllers
{
    public class NovelController : BaseController
    {
        //
        // GET: /Novel/

        public ActionResult Index(string page)
        {
            this.Internationalization();

            NovelModel model = new NovelModel();

            if (string.IsNullOrEmpty(page))
            {
                page = "1";
            }

            NovelService newsService = new NovelService();
            model.Page = Int32.Parse(page);

            model.PageSize = 10;//每页显示10张
            model.PageIndex = Int32.Parse(page);
            int count = 0;
            //视频列表
            model.Novels = newsService.GetNovelList(null, null, model.PageSize, model.PageIndex, out count);
            //分页
            if (model.Novels != null && model.Novels.Count > 0)
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
            model.Category = categoryService.GetCategoryById("novel");

            VideoService videoService = new VideoService();
            //猜你喜欢
            model.Like = videoService.GetLike(16);

            return View(model);
        }

        public ActionResult Show(string id)
        {
            this.Internationalization();

            NovelModel model = new NovelModel();

            if (string.IsNullOrEmpty(id))
            {
                id = "1";
            }

            NovelService novelService = new NovelService();
            model.Novel = novelService.GetNovelById(Int32.Parse(id));

            model.NovelArticles = novelService.GetNovelArticles(Int32.Parse(id));

            //猜你喜欢
            VideoService videoService = new VideoService();
            model.Like = videoService.GetLike(16);


            if (model.Novel == null)
            {
                model.Novel = new Novel();
                model.Novel.Title = "该小说不存在或已被删除";
            }

            return View(model);
        }

        public ActionResult Read(string id, string page)
        {
            this.Internationalization();

            NovelModel model = new NovelModel();

            if (string.IsNullOrEmpty(id))
            {
                id = "1";
            }

            NovelService novelService = new NovelService();
            model.Novel = novelService.GetNovelById(Int32.Parse(id));

            model.NovelArticles = novelService.GetNovelArticles(Int32.Parse(id));
            if (model.NovelArticles != null && model.NovelArticles.Count > 0)
            {
                int number = 0;
                foreach (var item in model.NovelArticles)
                {
                    number += 1;
                    if (number.ToString() == page)
                    {
                        model.NovelArticle = item;
                        break;
                    }
                }
            }

            //猜你喜欢
            VideoService videoService = new VideoService();
            model.Like = videoService.GetLike(16);


            if (model.Novel == null)
            {
                model.Novel = new Novel();
                model.Novel.Title = "该小说不存在或已被删除";
            }
            if (model.NovelArticle == null)
            {
                model.NovelArticle = new NovelArticle();
                model.NovelArticle.Title = "该小说章节不存在或已被删除";
            }

            return View(model);
        }

    }
}
