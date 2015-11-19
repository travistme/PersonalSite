using System.Web.Optimization;

namespace TElkins.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
//#if !Debug
//            bundles.UseCdn = true;
//            BundleTable.EnableOptimizations = true;
//#endif

            bundles.Add(new StyleBundle("~/Content/sitecss")
                .Include("~/Content/styles.css")
                .Include("~/Content/homestyles.css")
                .Include("~/Content/aboutstyles.css")
                .Include("~/Content/contactstyles.css")
                );

            bundles.Add(new StyleBundle("~/bundles/bootstrapcss", "//maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css")
                .Include("~/Content/bootstrap.css")
                );

            bundles.Add(new StyleBundle("~/bundles/bootstrap-themecss", "//maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap-theme.min.css")
                .Include("~/Content/bootstrap-theme.css")
                );

            bundles.Add(new ScriptBundle("~/bundles/jqueryjs")
                .Include("~/Scripts/jquery-{version}.js")
                );

            bundles.Add(new ScriptBundle("~/bundles/bootstrapscripts", "//maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js")
                .Include("~/Scripts/bootstrap.js")
                );

        }
    }
}