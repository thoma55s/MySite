using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;
using ThomasSite.App_Start;

namespace ThomasSite
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
