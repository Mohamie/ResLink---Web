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
        [SetClientClassMemberName("objectID")]
        public int ObjectID { get; set; }

        [SetClientClassMemberName("announcementDescription")]
        public string AnnouncementDescription { get; set; }


        [SetClientClassMemberName("announcementTitle")]
        public string AnnouncementTitle { get; set; }



        [SetClientClassMemberName("houseCommitee")]
        public HouseCommittee HouseCommittee { get; set; }
    }
}
