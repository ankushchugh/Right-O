using System.Web;
using System.Web.Optimization;

namespace RightO
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            

          

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/themeforest").Include("~/Scripts/jquery.min.js","~/Scripts/custom-isotope.js",
                "~/Scripts/custom-revolution.js",
                "~/Scripts/custom.js",
                "~/Scripts/hoverIntent.js",
                "~/Scripts/jack-in-the-box.js",
                "~/Scripts/jflickrfeed.js",
                "~/Scripts/jquery-ui-1.10.4.min.js",
                "~/Scripts/jquery.contact.js",
                "~/Scripts/jquery.countTo.js",
                "~/Scripts/jquery.fitvids.js",
                "~/Scripts/jquery.isotope.min.js",
                "~/Scripts/jquery.jplayer.min.js",
                
                "~/Scripts/jquery.parallax.js",
                "~/Scripts/jquery.prettyPhoto.js",
                "~/Scripts/owl.carousel.min.js",
                "~/Scripts/smoothScroll.js",
                "~/Scripts/superfish.js",
                "~/Scripts/waypoints.min.js",
                "~/Scripts/jquery.tweet.min.js",
                "~/Scripts/jquery.scrollTo.js",
                "~/Scripts/jquery.nav.js",
                "~/Scripts/jquery.themepunch.plugins.min.js",
                "~/Scripts/jquery.themepunch.revolution.min.js"
                
                ));
            
	

	        bundles.Add(new ScriptBundle("~/bundles/custom").Include());

	


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/css/style.css"));

            bundles.Add(new StyleBundle("~/Content/Sitecolor").Include("~/Content/css/red.css"));

            bundles.Add(new StyleBundle("~/Content/themseforestcss").Include("~/Content/css/superfish.css",
                "~/Content/css/prettyPhoto.css",
                "~/Content/css/font-awesome.css",
                "~/Content/css/superfish.css",
                "~/Content/css/audioplayer.css",
                "~/Content/css/owl.carousel.css",
                "~/Content/css/animate.css",
                "~/Content/css/responsive.css",
                "~/Content/css/googlefonts.css",
                "~/Content/css/settings.css"
                ));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}