﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AtchleyGameCenter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A brief history...";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Feel free to contact me.";

            return View();
        }
    }
}