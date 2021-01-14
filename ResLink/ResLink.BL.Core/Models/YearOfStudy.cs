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
        [SetClientClassMemberName("objectID")]
        public int ObjectID { get; set; }

        [SetClientClassMemberName("yearID")]
        public int YearID { get; set; }


        [SetClientClassMemberName("yearName")]
        public string YearName { get; set; }


    }
}
