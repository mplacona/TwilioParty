using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TwilioParty.Models
{
    public class Prize
    {
        public Prize()
        {
            Users = new List<User>();
        }

        [Key]
        public int PrizeId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public ICollection<User> Users { get; set; }
    }
}