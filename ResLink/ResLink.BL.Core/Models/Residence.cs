using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weborb.Service;

namespace ResLink.BL.Models
{
    public class Residence
    {
        [SetClientClassMemberName("objectID")]
        public int ObjectID { get; set; }

        [SetClientClassMemberName("residenceName")]
        public string ResidenceName { get; set; }

        [SetClientClassMemberName("residenceGender")]
        public Gender ResidenceGender { get; set; }

        [SetClientClassMemberName("residenceManager")]
        public ResidenceManager ResidenceManager { get; set; }
    }
}
