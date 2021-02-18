using System;
using System.Collections.Generic;
using System.Text;
using Weborb.Service;

namespace ResLink.BL.Models
{
    public class UserRole
    {
        [SetClientClassMemberName("objectId")]
        public string objectId { get; set; }

        [SetClientClassMemberName("roleId")]
        public int RoleId { get; set; }
        
        [SetClientClassMemberName("roleName")]
        public string RoleName { get; set; }

    }
}
