using System.Web;
using System.Web.Optimization;

namespace Portafolio
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.3.1.min.js"));

            bundles.Add(new ScriptBundle("~/plugin").Include(
            "~/Scripts/Plugin/jquery.mixitup.js",//filtro para el portafolio
            "~/Scripts/Plugin/smoothscrolling.jquery.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/styles.css"));

            bundles.Add(new StyleBundle("~/Content/AdminCss").Include(
                     "~/Content/bootstrap.css",
                     "~/Content/Site.css"));
        }
    }
}
