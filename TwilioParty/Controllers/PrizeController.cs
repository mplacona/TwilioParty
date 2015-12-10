using System.Linq;
using System.Web.Mvc;
using TwilioParty.Models;

namespace TwilioParty.Controllers
{
    public class PrizeController : Controller
    {
        // GET: Prize
        public ActionResult List()
        {
            var db = new TwilioPartyContext();
            var prizes = db.Prizes.ToList();
            ViewData.Model = prizes;
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add([Bind(Exclude = "PrizeId")] Prize prize)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            using (var db = new TwilioPartyContext())
            {
                db.Prizes.Add(prize);
                db.SaveChanges();

                return RedirectToAction("List");
            }
        }

        public ActionResult Delete(int id)
        {
            var db = new TwilioPartyContext();
            var prize = db.Prizes.FirstOrDefault(s => s.PrizeId.Equals(id));
            if (prize != null)
            {
                db.Prizes.Remove(prize);
                db.SaveChanges();
            }

            return RedirectToAction("List");
        }
    }
}