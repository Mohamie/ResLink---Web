using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendlessAPI;

namespace ResLink.DL
{
    public class ResLinkUserRegistration
    {
        public static BackendlessUser RegisterUserAccount(BackendlessUser newUser)
        {
            return Backendless.UserService.Register(newUser);
        }
        
    }
}
