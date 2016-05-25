using System.Web;
using System.Web.Optimization;

namespace Brain
{
	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/jquery-{version}.js"));

			bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
						"~/Scripts/jquery.validate*"));

			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
						"~/Scripts/modernizr-*"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
					  "~/Scripts/bootstrap.js",
					  "~/Scripts/respond.js"));
			//customAddedJS
			bundles.Add(new ScriptBundle("~/Scripts/Admin/js").Include(
						"~/Scripts/Admin/bootstrap.min.js",
						"~/Scripts/Admin/jquery.min.js"));

			bundles.Add(new ScriptBundle("~/Scripts/Admin/js1").Include(
						"~/Scripts/Admin/metisMenu.min.js",
						"~/Scripts/Admin/morris-data.js"));

			bundles.Add(new ScriptBundle("~/Scripts/Admin/js2").Include(
						"~/Scripts/Admin/morris.min.js",
						"~/Scripts/Admin/raphael-min.js"));

			bundles.Add(new ScriptBundle("~/Scripts/Admin/js3").Include(
						"~/Scripts/Admin/sb-admin-2.js"));
			
			//

			bundles.Add(new StyleBundle("~/Content/css").Include(
					  "~/Content/bootstrap.css",
					  "~/Content/site.css"));
			bundles.Add(new StyleBundle("~/AdminContent/css").Include(
					  "~/AdminContent/bootstrap.css",
					  "~/AdminContent/metisMenu.css"));
			bundles.Add(new StyleBundle("~/AdminContent/css1").Include(
					  "~/AdminContent/sb-admin-2.css",
					  "~/AdminContent/timeline.css"));
			bundles.Add(new StyleBundle("~/AdminContent/css2").Include(
					  "~/AdminContent/morris.css",
					  "~/AdminContent/font-awsome.min.css"));
		}
	}
}
