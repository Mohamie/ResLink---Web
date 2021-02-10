using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weborb.Service;

namespace ResLink.BL.Models
{
    public class Complaint
    {
        [SetClientClassMemberName("objectId")]
        public string objectId { get; set; }

        [SetClientClassMemberName("complaintTitle")]
        public string ComplaintTitle { get; set; }

        [SetClientClassMemberName("complaintDescription")]
        public string ComplaintDescription { get; set; }

        [SetClientClassMemberName("complaintVote")]
        public int ComplaintVote { get; set; }
    }
}
