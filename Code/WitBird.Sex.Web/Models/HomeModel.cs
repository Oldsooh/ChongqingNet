﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WitBird.Sex.Model;

namespace WitBird.Sex.Web.Models
{
    public class HomeModel
    {
        /// <summary>
        /// 幻灯片
        /// </summary>
        public List<Slide> Slides { get; set; }
        /// <summary>
        /// 最新资讯
        /// </summary>
        public List<News> NewNews { get; set; }
        /// <summary>
        /// 最新上传
        /// </summary>
        //public List<Album> NewUploads { get; set; }
        /// <summary>
        /// 推荐资讯
        /// </summary>
        public List<News> RecommendNews { get; set; }
        ///// <summary>
        ///// 最新推荐
        ///// </summary>
        //public List<Album> RecommendPictures { get; set; }
        ///// <summary>
        ///// 今日最美
        ///// </summary>
        //public List<Album> TopWomen { get; set; }
        ///// <summary>
        ///// 今日最帅
        ///// </summary>
        //public List<Album> TopMen { get; set; }
        ///// <summary>
        ///// dapigu
        ///// </summary>
        //public List<Album> RecommendDapigu { get; set; }
        ///// <summary>
        ///// damimi
        ///// </summary>
        //public List<Album> RecommendDamimi { get; set; }
        ///// <summary>
        ///// nenmeimei
        ///// </summary>
        //public List<Album> RecommendNenmeimei { get; set; }
        ///// <summary>
        ///// 推荐古装
        ///// </summary>
        //public List<Album> RecommendCostume { get; set; }
        ///// <summary>
        ///// 推荐型男
        ///// </summary>
        //public List<Album> RecommendStylishMan { get; set; }

        ///// <summary>
        ///// 是否外语
        ///// </summary>
        //public bool IsForeignLanguages { get; set; }

        ///// <summary>
        ///// 是否第一次访问
        ///// </summary>
        //public bool IsFirstVisit { get; set; }
    }
}