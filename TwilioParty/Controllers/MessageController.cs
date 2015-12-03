using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio.TwiML.Mvc;
using TwilioParty.Models;

namespace TwilioParty.Controllers
{
    public class MessageController : TwilioController
    {
        // GET: Message
        [HttpPost]
        public ActionResult Index()
        {
            using (var db = new TwilioPartyContext())
            {
                var entry = new User();
            }
            return Content("");
        }
    }
}