using System.Web;
using System.Web.Optimization;

namespace Mpparel
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





            bundles.Add(new ScriptBundle("~/Mpparel/JS").Include(
                "~/Plugins/jquery-3.5.0.js",
                "~/Plugins/nouislider/nouislider.js",
                "~/Plugins/popper.js",
                "~/Plugins/owl-carousel/owl.carousel.js",
                "~/Plugins/bootstrap/js/bootstrap.js",
                "~/Plugins/imagesloaded.pkgd.js",
                "~/Plugins/masonry.pkgd.js",
                "~/Plugins/isotope.pkgd.js",
                "~/Plugins/jquery.matchHeight.js",
                "~/Plugins/slick/slick/slick.js",
                "~/Plugins/jquery-bar-rating/dist/jquery.barrating.js",
                "~/Plugins/slick-animation.js",
                "~/Plugins/lightGallery-master/dist/js/lightgallery-all.js",
                "~/Plugins/sticky-sidebar/dist/sticky-sidebar.js",
                "~/Plugins/select2/dist/js/select2.full.js",
                "~/Plugins/gmap3.js",
                "~/Scripts/MpparelJs/main.js",
                "~/Scripts/MpparelJs/Drift.js",
                "~/Scripts/MpparelJs/Plugins.js",
                "~/Scripts/MpparelJs/custom.js",
                "~/Scripts/MpparelJs/mpparel-custom.js"
            ));


            bundles.Add(new StyleBundle("~/Mpparel/CSS").Include(
                     "~/Plugins/font-awesome/css/font-awesome.css",
                     "~/fonts/Linearicons/Linearicons/Font/demo-files/demo.css",
                     "~/Plugins/bootstrap/css/bootstrap.css",
                     "~/Plugins/owl-carousel/assets/owl.carousel.css",
                     "~/Plugins/owl-carousel/assets/owl.theme.default.css",
                     "~/Plugins/slick/slick/slick.css",
                     "~/Plugins/nouislider/nouislider.min.css",
                     "~/Plugins/lightGallery-master/dist/css/lightgallery.css",
                     "~/plugins/jquery-bar-rating/dist/themes/fontawesome-stars.css",
                     "~/Plugins/select2/dist/css/select2.css",
                     "~/Css/style.css",
                     "~/Css/market-place-1.css",
                     "~/Css/custom.css",
                     "~/Css/custom-color.css"
                     ));


        }
    }
}
