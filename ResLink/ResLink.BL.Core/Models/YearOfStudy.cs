using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weborb.Service;

namespace ResLink.BL.Models
{
    public class YearOfStudy
    {
        [SetClientClassMemberName("objectId")]
        public string ObjectID { get; set; }

        [SetClientClassMemberName("yearID")]
        public int YearID { get; set; }


        [SetClientClassMemberName("yearName")]
        public string YearName { get; set; }


    }
}
