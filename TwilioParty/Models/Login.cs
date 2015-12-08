﻿using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TwilioParty.Models
{
    public class LogIn
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [HiddenInput]
        public string ReturnUrl { get; set; }
    }
}