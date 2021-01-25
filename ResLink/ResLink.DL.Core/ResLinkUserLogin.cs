using BackendlessAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResLink.DL
{
    public class ResLinkUserLogin
    {
        public static async  Task<BackendlessUser> LoginUser(string email, string password)
        {
            return await Backendless.UserService.LoginAsync(email, password);
        }
    }
}
