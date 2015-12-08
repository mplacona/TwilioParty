using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace TwilioParty.Models
{
    public class Prize
    {
        public Prize()
        {
            Users = new List<User>();
        }

        [Key]
        [HiddenInput(DisplayValue = false)]
        [Display(AutoGenerateField = false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PrizeId { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public int Quantity { get; set; }

        public ICollection<User> Users { get; set; }
    }
}