using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendlessAPI;

namespace ResLink.Web.Data
{
    public class BackendlessService
    {
        private static string APPLICATIONID = "B5ACCDD7-2895-D5A4-FFF1-63C024AFED00";
        private static string APIKEY = "E68870EC-779E-4591-A4F5-A426E26023EE";

        public BackendlessService()
        {
            Backendless.InitApp(APPLICATIONID, APIKEY);
        }
    }
}
