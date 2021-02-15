using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendlessAPI;
using ResLink.BL.Models;

namespace ResLink.Web.Data
{
    public class BackendlessService
    {
        private static string APPLICATIONID = "A77E777B-228F-C5D4-FF44-76E32569F500";
        private static string APIKEY = "083CB49F-0C5F-4A06-A8A4-673278F9115A";

        public BackendlessService()
        {
            Backendless.InitApp(APPLICATIONID, APIKEY);

            Backendless.Data.MapTableToType("Residence", typeof(Residence));
            Backendless.Data.MapTableToType("Gender", typeof(Gender));
            Backendless.Data.MapTableToType("Announcement", typeof(Announcement));
            Backendless.Data.MapTableToType("Attendance", typeof(Attendance));
            Backendless.Data.MapTableToType("Complaint", typeof(Complaint));
            Backendless.Data.MapTableToType("HCRole", typeof(HCRole));
            Backendless.Data.MapTableToType("HouseCommittee", typeof(HouseCommittee));
            Backendless.Data.MapTableToType("Meeting", typeof(Meeting));
            Backendless.Data.MapTableToType("ResidenceManager", typeof(ResidenceManager));
            Backendless.Data.MapTableToType("Student", typeof(Student));
            Backendless.Data.MapTableToType("Event", typeof(Event));
            Backendless.Data.MapTableToType("ComplaintStatus", typeof(ComplaintStatus));

        }
    }
}
