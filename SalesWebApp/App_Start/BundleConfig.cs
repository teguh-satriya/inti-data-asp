using System.Web;
using System.Web.Optimization;

namespace SalesWebApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryease").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.easing.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Vendor/bootstrap/js/bootstrap.bundle.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/chartjs").Include(
                        "~/Vendor/chart.js/Chart.min.js"));

            bundles.Add(new StyleBundle("~/bundles/datatable-css").Include(
                        "~/Vendor/datatables/dataTables.bootstrap4.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/datatable-js").Include(
                        "~/Vendor/datatables/jquery.dataTables.min.js",
                        "~/Vendor/datatables/dataTables.bootstrap4.min.js"));


            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/assets/js").Include(
                      "~/Scripts/sb-admin-2.min.js"));

            bundles.Add(new StyleBundle("~/assets/css").Include(
                      "~/Content/css/sb-admin-2.min.css"));

            bundles.Add(new StyleBundle("~/bundles/fa").Include(
                      "~/Vendor/fontawesome/css/all.min.css",
                      "~/Vendor/fontawesome/css/font.css"));
        }
    }
}
