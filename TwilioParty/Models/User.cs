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
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
        public string Message { get; set; }

        public int PrizeId { get; set; }
        public virtual Prize Prize { get; set; }
    }
}