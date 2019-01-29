using System;
using System.Web.Mvc;

namespace ThomasSite.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Error(int statusCode)
        {
            Response.StatusCode = statusCode;
            ViewBag.StatusCode = statusCode + "";
            return View();
        }
    }
}