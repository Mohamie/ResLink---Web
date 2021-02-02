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
        public string objectId { get; set; }

        [SetClientClassMemberName("hcRole")]
        public string HcRoleName { get; set; }

        [SetClientClassMemberName("hcRoleID")]
        public int HcRoleID { get; set; }
    }
}
