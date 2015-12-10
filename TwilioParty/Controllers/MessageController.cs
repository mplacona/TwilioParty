using System;
using System.Linq;
using System.Web.Mvc;
using Twilio.TwiML;
using Twilio.TwiML.Mvc;
using TwilioParty.Models;

namespace TwilioParty.Controllers
{
    public class MessageController : TwilioController
    {
        // GET: Message
        [AllowAnonymous] 
        [HttpPost]
        public ActionResult Index(User data)
        {
            using (var db = new TwilioPartyContext())
            {
                var existingUserCount = db.Users.Count(a => a.From == data.From);
                var twiml = new TwilioResponse();
                if (existingUserCount > 0)
                {
                    return TwiML(twiml.Message("It seems you've already got a prize, but check this out for more goodies http://www.berlintechs.org/#party"));
                }
                // Get a random prize from DB
                var prize = db.Prizes.Where(q => q.Quantity > 0).OrderBy(r => Guid.NewGuid()).Take(1).First();
                if (prize != null)
                {    
                    prize.Quantity = prize.Quantity - 1;
                    db.SaveChanges();

                    var entry = new User { From = data.From, Body = data.Body, PrizeId = prize.PrizeId };
                    db.Users.Add(entry);
                    db.SaveChanges();

                    return TwiML(twiml.Message("Congratulations, you won a " + prize.Name + "! But that's not all you get, check this out http://www.berlintechs.org/#party"));
                }

                return Content("");
            }
            
        }

        [HttpGet]
        public ActionResult List()
        {
            var db = new TwilioPartyContext();
            var users = db.Users.ToList();
            ViewData.Model = users;
            return View();
        }
    }
}