using BackendlessAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weborb.Service;

namespace ResLink.BL.Models
{
    public class HouseCommittee
    {
        [SetClientClassMemberName("objectId")]
        public string objectId { get; set; }

        [SetClientClassMemberName("hcAccount")]
        public BackendlessUser HcAccount { get; set; }

        [SetClientClassMemberName("hcRole")]
        public HCRole HcRole { get; set; }

        [SetClientClassMemberName("student")]
        public Student Student { get; set; }
    }
}
