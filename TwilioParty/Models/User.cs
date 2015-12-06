using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TwilioParty.Models
{
    public class User
    {
        [Key]
        public string From { get; set; }
        public string Body { get; set; }

        public int PrizeId { get; set; }
        public virtual Prize Prize { get; set; }
    }
}