using ResLink.BL.Models;
using ResLink.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResLink.Web.ViewModels
{
    public class ResidenceViewModel
    {
        [Required]
        public string ResidenceName { get; set; }
        
        [Required]
        public string ManagerFirstName { get; set; }
        [Required]
        public string ManagerLastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
       
        [Required]
        public string Password { get; set; }
        
        [Required]
        [CompareProperty("Password", ErrorMessage = "Password and Confirm Password must match")]
        public string ConfirmPassword { get; set; }
        
        [Required]
        public List<Gender> ResidenceGender { get; set; }

        public Gender Gender { get; set; }

        public async Task<UserRole> GetManagerRole()
        {
            return await UserRoleRepository.GetManagerRole();
        }


        public StudentRoleViewModel ManagerRole { get { return StudentRoleViewModel.Manager; } set { ManagerRole = value; } }

    }
}
