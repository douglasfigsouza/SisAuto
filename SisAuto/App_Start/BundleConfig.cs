using System.Web;
using System.Web.Optimization;

namespace SisAuto
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/meusScripts").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/angular.js",
                      "~/Scripts/SisAutoApp/Modules.js",
                      "~/Scripts/SisAutoApp/Controllers.js",
                      "~/Scripts/SisAutoApp/Service.js",
                      "~/Scripts/jquery.metisMenu.js",
                      "~/Scripts/morris/raphael-2.1.0.min.js",
                      "~/Scripts/morris/morris.js",
                      "~/Scripts/custom.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/css/font-awesome.css",
                      "~/Scripts/morris/morris-0.4.3.min.css",
                      "~/Content/css/custom.css"));
        }
    }
}
