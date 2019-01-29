using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;
using ThomasSite.App_Start;
using System.Web;
using System;
using ThomasSite.Controllers;

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

        public void Application_Error(Object sender, EventArgs e)


        {
            Exception exception = Server.GetLastError();
            Server.ClearError();

            var routeData = new RouteData();
            routeData.Values.Add("controller", "Error");
            routeData.Values.Add("action", "Error");
            routeData.Values.Add("exception", exception);

            if (exception.GetType() == typeof(HttpException))
            {
                routeData.Values.Add("statusCode", ((HttpException)exception).GetHttpCode());
            }
            else
            {
                routeData.Values.Add("statusCode", 500);
            }

            Response.TrySkipIisCustomErrors = true;
            IController controller = new ErrorController();
            controller.Execute(new RequestContext(new HttpContextWrapper(Context), routeData));
            Response.End();
        }
    }
}
