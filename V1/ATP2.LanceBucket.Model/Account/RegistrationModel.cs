﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATP2.LanceBucket.Model.Account
{
    public class RegistrationModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string UserName { get; set; }
        public int UserType { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}

