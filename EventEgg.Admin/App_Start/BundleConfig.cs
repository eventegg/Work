using System.Web;
using System.Web.Optimization;

namespace EventEgg.Admin
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
            /*
            bundles.Add(new StyleBundle("~/Content/assets/css").Include(
                "~/Content/assets/css/animate.css",
                "~/Content/assets/css/print.css",
                "~/Content/assets/css/style-metro.css",
                "~/Content/assets/css/style-non-responsive.css",
                "~/Content/assets/css/style-responsive.css",
                "~/Content/assets/css/style.css"));
            
            bundles.Add(new StyleBundle("~/Content/assets/css/page").Include(
                "~/Content/assets/css/page/about-us.css",
                "~/Content/assets/css/page/blog.css",
                "~/Content/assets/css/page/coming-soon.css",
                "~/Content/assets/css/page/email.css",
                "~/Content/assets/css/page/error.css",
                "~/Content/assets/css/page/inbox.css",
                "~/Content/assets/css/page/invoice.css",
                "~/Content/assets/css/page/lock.css",
                "~/Content/assets/css/page/login-soft.css",
                "~/Content/assets/css/page/login.css",
                "~/Content/assets/css/page/news.css",
                "~/Content/assets/css/page/pricing-tables.css",
                "~/Content/assets/css/page/profile.css",
                "~/Content/assets/css/page/promo.css",
                "~/Content/assets/css/page/search.css",
                "~/Content/assets/css/page/timeline.css"));

            bundles.Add(new StyleBundle("~/Content/assets/css/themes").Include(
                "~/Content/assets/css/themes/blue.css",
                "~/Content/assets/css/themes/brown.css",
                "~/Content/assets/css/themes/default.css",
                "~/Content/assets/css/themes/grey.css",
                "~/Content/assets/css/themes/light.css",
                "~/Content/assets/css/themes/purple.css"));

            
            bundles.Add(new StyleBundle("~/Content/assets/plugins/bootstrap/css").Include(
                "~/Content/assets/plugins/bootstrap/css/bootstrap.min.css",
                "~/Content/assets/plugins/bootstrap/css/bootstrap-responsive.min.css",
                "~/Content/assets/plugins/font-awesome/css/font-awesome.min.css",
                "~/Content/assets/plugins/uniform/css/uniform.default.css"));
            */
        }
    }
}