using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HiWorld.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ViewResult ProductIndex()
        {
            return View();
        }

        // Product/Liste
        public ViewResult Liste()
        {
            return View();
        }

        public ViewResult Kategori()
        {
            return View();
        }
    }
}