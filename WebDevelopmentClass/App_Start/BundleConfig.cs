﻿using System.Web;
using System.Web.Optimization;

namespace WebDevelopmentClass
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery-ui-{version}.js"
            ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/syntaxHighlighter").Include(
                "~/Scripts/shCore.js",
                "~/Scripts/shBrushXml.js",
                "~/Scripts/shBrushCss.js",
                "~/Scripts/shBrushCSharp.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/normalize.css",
                      "~/Content/shCore.css",
                      "~/Content/shThemeDefault.css",
                      "~/Content/jquery-ui-{version}.css",
                      "~/Content/stripes.css"));
        }
    }
}
