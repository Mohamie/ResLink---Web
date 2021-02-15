using System;
using System.Collections.Generic;
using System.Text;
using Weborb.Service;

namespace ResLink.BL.Models
{
    public class ComplaintStatus
    {

        [SetClientClassMemberName("statusID")]
        public int StatusID { get; set; }
        
        [SetClientClassMemberName("statusName")]
        public string StatusName { get; set; }
    }
}
