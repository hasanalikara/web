﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HiWorld.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Iletisim()
        {
            return View();
        }

        public ViewResult Hakkinda()
        {
            return View();
        }
    }
}