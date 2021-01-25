using System;
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
        public static async Task<BackendlessUser> RegisterManagerAccount(ResidenceManager manager)
        {
            BackendlessUser _manager = new BackendlessUser();
            _manager.Email = manager.ManagerAccount.Email;
            _manager.Password = manager.ManagerAccount.Password;
            _manager.SetProperty("residenceEmail", _manager.Email);
            _manager.SetProperty("userRole", 1);

            return await Backendless.UserService.RegisterAsync(_manager);
        }
        
       
    }
}
