using System;
using System.Web;
using System.Web.Mvc;

namespace ThomasSite.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        [Route("Resume")]
        public ViewResult Resume()
        {
            return View();
        }
        [Route("ACM")]
        public ViewResult Acm()
        {
            return View();
        }
        [Route("test")]
        public ViewResult test()
        {
            throw new HttpException(500, "500");
        }
        
    }
}