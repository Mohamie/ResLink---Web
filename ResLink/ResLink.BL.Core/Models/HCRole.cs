using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weborb.Service;

namespace ResLink.BL.Models
{
    public class HCRole
    {
        [SetClientClassMemberName("objectId")]
        public string ObjectID { get; set; }

        [SetClientClassMemberName("hcRole")]
        public string HcRole { get; set; }

        [SetClientClassMemberName("hcRoleID")]
        public int HcRoleID { get; set; }
    }
}
