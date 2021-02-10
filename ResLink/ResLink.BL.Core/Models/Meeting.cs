using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weborb.Service;

namespace ResLink.BL.Models
{
    public class Meeting
    {
        [SetClientClassMemberName("objectId")]
        public string objectId { get; set; }

        [SetClientClassMemberName("meetingTitle")]
        public string MeetingTitle { get; set; }

        [SetClientClassMemberName("meetingDescsription")]
        public string MeetingDescsription { get; set; }
    }
}
