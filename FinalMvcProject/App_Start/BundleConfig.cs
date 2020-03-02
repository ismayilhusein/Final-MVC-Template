using System.Web;
using System.Web.Optimization;

namespace FinalMvcProject
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            bundles.Add(new ScriptBundle("~/bundles/LoginScripts").Include(
                       "~/Areas/Control/Public/vendor/jquery/jquery.min.js",
                       "~/Areas/Control/Public/vendor/bootstrap/js/bootstrap.bundle.min.js",
                       "~/Areas/Control/Public/vendor/jquery-easing/jquery.easing.min.js",
                       "~/Areas/Control/Public/js/sb-admin-2.min.js"));


            bundles.Add(new ScriptBundle("~/bundles/Login").Include(
                      "~/Areas/Control/Public/vendor/fontawesome-free/css/all.min.css",
                      "~/Areas/Control/Public/css/sb-admin-2.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/jquery.validate.unobtrusive.min.js"));

        }
    }
}
