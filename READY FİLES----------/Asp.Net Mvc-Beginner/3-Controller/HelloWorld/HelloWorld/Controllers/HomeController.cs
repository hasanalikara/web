using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Home Index";
        }

        public string Contact()
        {
            return "Home Contact";
        }

        public string About()
        {
            return "Home About";
        }
    }
}