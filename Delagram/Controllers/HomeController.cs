﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Delagram.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Posts";

            List<string> post_names = new List<string>();
            post_names.Add("post 1");
            post_names.Add("post 2");

            return View(post_names);
        }
    }
}
