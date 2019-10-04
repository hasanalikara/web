using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace BanzHow.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundle/css")
                .Include(
                    "~/banzhow/css/bootstrap.css",
                    "~/banzhow/css/style.css"
                ));

            bundles.Add(new ScriptBundle("~/bundle/javascript")
              .Include(
                  "~/banzhow/js/jquery-1.10.2.js",
                  "~/banzhow/js/bootstrap.js",
                  "~/banzhow/js/plugins.js",
                  "~//banzhow/js/banzhow.js"
              ));

        }
    }
}