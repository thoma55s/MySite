using System.Web.Mvc;

namespace ThomasSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Resume()
        {
            return View();
        }

        public ViewResult Acm()
        {
            return View();
        }
    }
}