﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WitBird.Sex.Model;

namespace WitBird.Sex.Web.Areas.Admin.Models
{
    public class SlideModel
    {
        public Slide Slide { get; set; }

        public List<Slide> Slides { get; set; }
    }
}