using BackendlessAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weborb.Service;

namespace ResLink.BL.Models
{
    public class ResidenceManager
    {
        [SetClientClassMemberName("objectID")]
        public int ObjectID { get; set; }

        [SetClientClassMemberName("managerFirstName")]
        public string ManagerFirstName { get; set; }

        [SetClientClassMemberName("managerLastName")]
        public string ManagerLastName { get; set; }

        [SetClientClassMemberName("managerAccount")]
        public BackendlessUser ManagerAccount { get; set; }
    }
}
