﻿using mvc_intermediate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_intermediate.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            UrunKategoriModel model = new UrunKategoriModel();

            model.UrunSayisi = Veritabani.Liste.Count();
            model.Urunler = Veritabani.Liste;

            return View(model);
        }
    }
}