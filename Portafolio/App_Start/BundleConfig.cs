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
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/plugin").Include(
            "~/Scripts/Plugin/skill.js",
            "~/Scripts/Plugin/jquery.circlechart.js",
            "~/Scripts/Plugin/jquery.mixitup.js",//filtro para el portafolio
            "~/Scripts/Plugin/custom.js",
            "~/Scripts/Plugin/smoothscrolling.jquery.js",
            "~/Scripts/Plugin/jquery.appear.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/styles.css"));

            bundles.Add(new StyleBundle("~/Content/Bars").Include(
              "~/Content/bars.css"));
        }
    }
}
