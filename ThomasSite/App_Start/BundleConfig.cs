using System.Web.Optimization;
namespace ThomasSite.App_Start
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;
            BundleTable.EnableOptimizations = true;
            #if DEBUG
            //Styles
            Styles(bundles);
                bundles.Add(new StyleBundle("~/bundles/fontawesome", "https://use.fontawesome.com/releases/v5.3.1/css/all.css"));

                //Scripts
                bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-3.3.1.js"));
                bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));


            #else            
                //Styles
                Styles(bundles);
                

                //Scripts
                bundles.Add(new ScriptBundle("~/bundles/jquery", "https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.3.1.min.js"));
                bundles.Add(new ScriptBundle("~/bundles/bootstrap", "https://ajax.aspnetcdn.com/ajax/bootstrap/4.0.0/bootstrap.min.js"));
                
            #endif
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));



        }
        static void Styles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css").Include("~/Content/Site.css", "~/Content/bootstrap.css"));
            bundles.Add(new StyleBundle("~/bundles/fontawesome", "https://use.fontawesome.com/releases/v5.3.1/css/all.css"));
        }
    }
}