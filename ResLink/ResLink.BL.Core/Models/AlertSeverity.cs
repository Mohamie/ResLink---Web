using System;
using System.Collections.Generic;
using System.Text;
using Weborb.Service;

namespace ResLink.BL.Models
{
    public class AlertSeverity
    {
        [SetClientClassMemberName("objectId")]
        public string objectId { get; set; }

        [SetClientClassMemberName("severityId")]
        public int SeverityId { get; set; }

        [SetClientClassMemberName("severityTitle")]
        public string SeverityTitle { get; set; }

    }
}
