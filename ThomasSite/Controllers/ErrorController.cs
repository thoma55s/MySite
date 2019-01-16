using System.Web.Mvc;

namespace ThomasSite.Controllers
{
    public class ErrorController : Controller
    {
        private const int NotFoundCode404 = 404;
        private const int InternalErrorCode500 = 500;
        public ActionResult NotFound404()
        {
            Response.StatusCode = NotFoundCode404;
            return View();
        }
    }
}