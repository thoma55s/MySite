using System.Web.Optimization;
namespace ThomasSite.App_Start
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            #if DEBUG                         
                bundles.UseCdn = false;
                BundleTable.EnableOptimizations = false;
            #else
                bundles.UseCdn = true;
                BundleTable.EnableOptimizations = true;
                bundles.Add(new ScriptBundle("~/bundles/jquery", "https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.3.1.min.js").Include(
                        "~/Scripts/jquery-3.3.1.js"));
            #endif

        }
    }
}