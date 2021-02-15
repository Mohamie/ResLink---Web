using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weborb.Service;

namespace ResLink.BL.Models
{
    public class Announcement
    {
        [SetClientClassMemberName("objectId")]
        public string objectId { get; set; }

        [SetClientClassMemberName("created")]
        public DateTime DateCreated { get; set; }

        public string GetDateCreated { get { return DateCreated.ToString("dd MMMM yyyy"); } }

        [SetClientClassMemberName("announcementDescription")]
        public string AnnouncementDescription { get; set; }


        [SetClientClassMemberName("announcementTitle")]
        public string AnnouncementTitle { get; set; }

        [SetClientClassMemberName("residenceID")]
        public string ResidenceID { get; set; }

        [SetClientClassMemberName("hc")]
        public HouseCommittee HouseCommittee { get; set; }
    }
}
