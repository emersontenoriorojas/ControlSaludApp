using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ControlSaludApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.

            bundles.Add(new StyleBundle("~/bundles/css")
            .Include(
                    "~/Content/css/bootstrap.css",
                    "~/Content/css/bootstrap.min.css",
                    "~/Content/css/custom.min.css"
                    ));

            bundles.Add(new ScriptBundle("~/bundles/js")
            .Include(
                    "~/Content/js/bootstrap.min.js",
                    "~/Content/js/custom.js",
                    "~/Content/js/jquery.min.js",
                    "~/Content/js/popper.min.js",
                    "~/Content/js/bootstrap.bundle.js"
                    ));


        }
    }
}