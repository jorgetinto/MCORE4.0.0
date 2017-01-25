using System;
using System.Web.Optimization;

namespace Cobranza.Core.MvcApplication
{
    public class BundleConfig
    {
        // Para obtener más información acerca de Bundling, consulte http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            if (bundles == null)
            {
                throw new ArgumentNullException("bundles");
            }

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/EssentialScripts/jquery-1.11.3.min.js",
                        "~/Scripts/EssentialScripts/jquery.numeric.min.js",
                        "~/Scripts/EssentialScripts/EssentialScripts/jquery.contextmenu.r2.min.js",
                        "~/Scripts/EssentialScripts/jquery.fileDownload.js",
                        "~/Scripts/EssentialScripts/jquery-migrate-1.2.1.min.js",
                        "~/Scripts/EssentialScripts/jquery.searchable-1.1.0.min.js",
                        "~/Scripts/EssentialScripts/jquery.searchable-ie-1.1.0.min.js",
                        "~/Scripts/EssentialScripts/jquery.dataTables.min.js",
                        "~/Scripts/EssentialScripts/dataTables.bootstrap.min.js"));


            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/EssentialScripts/jquery.unobtrusive-ajax.min.js",
                        "~/Scripts/EssentialScripts/jquery.validate.min.js",
                        "~/Scripts/EssentialScripts/jquery.validate.unobtrusive.min.js",
                        "~/Scripts/EssentialScripts/additional-methods.min.js",
                        "~/Scripts/EssentialScripts/messages_es.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                       "~/Content/bootstrap-3.3.7/js/bootstrap.min.js"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información sobre 
            // los formularios. De este modo, estará preparado para la producción y podrá utilizar la herramienta de 
            // creación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/EssentialScripts/modernizr-1.7.min.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrap-3.3.7/css").Include(
                "~/Content/bootstrap-3.3.7/css/bootstrap.min.css",
                "~/Content/bootstrap-3.3.7/css/custom.min.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/normalize.css",
                "~/Content/PagedList.css",
                "~/Content/Site.css",
                "~/Content/dataTables.bootstrap.min.css"));
        }
    }
}