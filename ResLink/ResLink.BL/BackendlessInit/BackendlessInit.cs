using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResLink.BL.BackendlessInit
{
    public class BackendlessInit
    {
        private static readonly string APPLICATIONID = "B5ACCDD7-2895-D5A4-FFF1-63C024AFED00";
        private static readonly string APIKEY = "E68870EC-779E-4591-A4F5-A426E26023EE";

        public static void Init()
        {
            if (APPLICATIONID.Length == 0 || APIKEY.Length == 0)
                throw new Exception("Please make sure to enter your ApplicationID and API Key in BackendlessInit.cs. The file is located in the ResLink.BL project (BL/BackendlessInit/BackendlessInit.cs)");

            // initialize app
            BackendlessAPI.Backendless.InitApp(APPLICATIONID, APIKEY);
        }
    }
}
