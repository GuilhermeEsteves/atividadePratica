﻿using System.Web;
using System.Web.Optimization;

namespace AtividadePratica
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.10.2.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                     "~/Scripts/knockout-3.4.0.js",
                     "~/Scripts/knockout.mapping.js",
                     "~/Scripts/bootstrap.min.js",
                     "~/Scripts/select2.min.js",
                     "~/Scripts/toastr.min.js",
                     "~/Scripts/jquery.mask.min.js",
                     "~/Scripts/common.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/select2.css",
                      "~/Content/toastr.min.css"));
        }
    }
}
