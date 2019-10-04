using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        public string Index()
        {
            return "Ürün Index";
        }

        public string Liste()
        {
            return "Urun Listesi";
        }

        public string UrunDetay()
        {
            return "Urun UrunDetay";
        }
    }
}