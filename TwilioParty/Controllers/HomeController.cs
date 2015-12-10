using System.Web.Mvc;

namespace TwilioParty.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [AllowAnonymous] 
        public ActionResult WhatsUp()
        {
            return Content("Ahoy! I'm up!");
        }
    }
}