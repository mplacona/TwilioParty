using System.ComponentModel.DataAnnotations;

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