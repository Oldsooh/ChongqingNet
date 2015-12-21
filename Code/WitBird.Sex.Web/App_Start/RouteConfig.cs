using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WitBird.Sex.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var newsCategories = (Cache.NewsCategories ?? new List<Model.NewsCategory>()).Select(x => x.Id);
            var constraintString = "news|" + string.Join("|", newsCategories);

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //新闻查看
            routes.MapRoute(
                name: "newsshow",
                url: "{category}/{id}.html",
                defaults: new { controller = "News", action = "Show" },
                constraints: new { category = constraintString, id = @"[\d]{0,8}" },
                namespaces: new string[] { "WitBird.Sex.Web.Controllers" }
            );
            //新闻分类
            routes.MapRoute(
                name: "newspage",
                url: "{category}/{page}",
                defaults: new { controller = "News", action = "Index", page = "1" },
                constraints: new { category = constraintString, page = @"[\d]{0,5}" },
                namespaces: new string[] { "WitBird.Sex.Web.Controllers" }
            );

            //搜索
            routes.MapRoute(
                name: "Search",
                url: "search/{keywords}/{page}",
                defaults: new { controller = "Search", action = "Index", page = "1" },
                constraints: new { page = @"[\d]{0,5}" },
                namespaces: new string[] { "WitBird.Sex.Web.Controllers" }
            );

            #region Unuseful Routes

            ////展示图片(第一张)
            //routes.MapRoute(
            //    name: "Show1",
            //    url: "{category}/{id}.html",
            //    defaults: new { controller = "Album", action = "Show" },
            //    constraints: new { category = @"damimi|dapigu|nenmeimei|show", id = @"[\d]{0,8}" },
            //    namespaces: new string[] { "WitBird.Sex.Web.Controllers" }
            //);

            ////展示图片（从第二张起）
            //routes.MapRoute(
            //    name: "Show2",
            //    url: "{category}/{id}-{page}.html",
            //    defaults: new { controller = "Album", action = "Show", page = "1" },
            //    constraints: new { category = @"damimi|dapigu|nenmeimei|show", id = @"[\d]{0,8}", page = @"[\d]{0,5}" },
            //    namespaces: new string[] { "WitBird.Sex.Web.Controllers" }
            //);

            ////图片分类
            //routes.MapRoute(
            //    name: "Category",
            //    url: "{category}/{page}",
            //    defaults: new { controller = "Album", action = "Category", page = "1" },
            //    constraints: new { category = @"damimi|dapigu|nenmeimei", page = @"[\d]{0,5}" },
            //    namespaces: new string[] { "WitBird.Sex.Web.Controllers" }
            //);

            ////播放视频
            //routes.MapRoute(
            //    name: "Play",
            //    url: "play/{id}.html",
            //    defaults: new { controller = "Video", action = "Play" },
            //    constraints: new { id = @"[\d]{0,8}" },
            //    namespaces: new string[] { "SichuanIT.Sex.Web.Controllers" }
            //);


            ////新闻/小说查看
            //routes.MapRoute(
            //    name: "View",
            //    url: "{controller}/{id}.html",
            //    defaults: new { action = "Show" },
            //    constraints: new { controller = @"News|Novel", id = @"[\d]{0,8}" },
            //    namespaces: new string[] { "SichuanIT.Sex.Web.Controllers" }
            //);


            ////小说内容查看
            //routes.MapRoute(
            //    name: "Read",
            //    url: "novel/{id}-{page}.html",
            //    defaults: new { controller = "Novel", action = "Read", page = "1" },
            //    constraints: new { id = @"[\d]{0,8}", page = @"[\d]{0,5}" },
            //    namespaces: new string[] { "SichuanIT.Sex.Web.Controllers" }
            //);


            ////新闻/小说/视频主页
            //routes.MapRoute(
            //    name: "NewsNovel",
            //    url: "{controller}/{page}",
            //    defaults: new { action = "Index", page = "1" },
            //    constraints: new { controller = @"News|Novel|Video", page = @"[\d]{0,5}" },
            //    namespaces: new string[] { "SichuanIT.Sex.Web.Controllers" }
            //);



            ////手机视频播放
            //routes.MapRoute(
            //    name: "MPlay",
            //    url: "v/{id}",
            //    defaults: new { controller = "M", action = "V" },
            //    constraints: new { id = @"[\d]{0,8}" },
            //    namespaces: new string[] { "SichuanIT.Sex.Web.Controllers" }
            //);

            ////手机视频主页
            //routes.MapRoute(
            //    name: "TV",
            //    url: "tv/{page}",
            //    defaults: new { controller = "M", action = "TV", page = "1" },
            //    constraints: new { page = @"[\d]{0,5}" },
            //    namespaces: new string[] { "SichuanIT.Sex.Web.Controllers" }
            //);

            ////手机展示图片(第一张)
            //routes.MapRoute(
            //    name: "Pic1",
            //    url: "pic/{id}",
            //    defaults: new { controller = "M", action = "Pic", page = "1" },
            //    constraints: new { id = @"[\d]{0,8}" },
            //    namespaces: new string[] { "SichuanIT.Sex.Web.Controllers" }
            //);

            ////手机展示图片（从第二张起）
            //routes.MapRoute(
            //    name: "Pic2",
            //    url: "pic/{id}-{page}",
            //    defaults: new { controller = "M", action = "Pic", page = "1" },
            //    constraints: new { id = @"[\d]{0,8}", page = @"[\d]{0,5}" },
            //    namespaces: new string[] { "SichuanIT.Sex.Web.Controllers" }
            //);

            ////手机图片分类
            //routes.MapRoute(
            //    name: "MCategory",
            //    url: "m/{category}/{page}",
            //    defaults: new { controller = "M", action = "Category", page = "1" },
            //    constraints: new { category = @"xinggan|qingchun|chemo|mingxing|meitui|zhifu|renti|jiepai", page = @"[\d]{0,5}" },
            //    namespaces: new string[] { "SichuanIT.Sex.Web.Controllers" }
            //);
            #endregion Unuseful Routes

            //默认
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: null,
                namespaces: new string[] { "WitBird.Sex.Web.Controllers" }
            );
        }
    }
}