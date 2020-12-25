using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weborb.Service;

namespace ResLink.BL.Models
{
    public class Event
    {
        [SetClientClassMemberName("objectID")]
        public int ObjectID { get; set; }

        [SetClientClassMemberName("eventDescription")]
        public string EventDescription { get; set; }

        [SetClientClassMemberName("eventTitle")]
        public string EventTitle { get; set; }
    }
}
