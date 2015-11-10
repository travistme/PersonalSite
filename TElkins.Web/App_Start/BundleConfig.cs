using System;
using System.Web;
using System.Web.Optimization;

namespace TElkins.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/clientfeaturescripts").Include(
                "~/Scripts/jquery-{version}.js"));
        }
    }
}