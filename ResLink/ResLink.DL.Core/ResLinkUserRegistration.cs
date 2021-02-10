﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendlessAPI;
using ResLink.BL.Models;

namespace ResLink.DL
{
    public class ResLinkUserRegistration
    {
        public static async Task<BackendlessUser> RegisterUserAccount(string email, string password, int roleID)
        {
            BackendlessUser user = new BackendlessUser();
            user.Email = email;
            user.Password = password;
            user.SetProperty("residenceEmail", "res@test.com");
            user.SetProperty("userRole", roleID);

            return await Backendless.UserService.RegisterAsync(user);
        }
        
       
    }
}
