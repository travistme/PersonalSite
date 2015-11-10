using System.Web.Optimization;

namespace TElkins.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/*.css"));

            bundles.Add(new ScriptBundle("~/bundles/clientfeaturescripts").Include(
                "~/Scripts/jquery-{version}.js"));
        }
    }
}