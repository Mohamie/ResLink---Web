﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResLink.Web.ViewModels
{
    public class StudentViewModel
    {
        [Required]
        public string StudentNumber { get; set; }

        [Required]
        public string FirstNames { get; set; }

        [Required]
        public string LastName { get; set; }
        
        public GenderViewModel Gender { get; set; }

        [Required]
        [EmailAddress]
        public string  Email { get; set; }

        [Required]
        public string Password { get; set; }
        
        public StudentRoleViewModel Role{ get; set; }
        
        public HCRoleViewModel HCRole{ get; set; }



    }
}