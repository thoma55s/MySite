using System;
using System.Web.Mvc;
using System.Linq;
using ThomasSite.Models;

namespace ThomasSite.Controllers
{
    public class ErrorController : Controller
    {
        Error[] errorArray = 
        {
            new Error {ID = 404, Message = "Resource not found." },
            new Error {ID = 500, Message = "Internal server error." }
        };
        public ActionResult Error(int statusCode)
        {
            Response.StatusCode = statusCode;
            ViewBag.StatusCode = statusCode;
            
            return View(errorArray.SingleOrDefault(item => item.ID == statusCode));
        }
    }
}