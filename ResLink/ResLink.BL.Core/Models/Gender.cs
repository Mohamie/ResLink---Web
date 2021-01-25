using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weborb.Service;
//using Weborb.Service;


namespace ResLink.BL.Models
{
    public class Gender
    {
        [SetClientClassMemberName("objectId")]
        public string ObjectID { get; set; }

        [SetClientClassMemberName("genderID")]
        public string  GenderID { get; set; }

        [SetClientClassMemberName("genderName")]
        public string GenderName { get; set; }


    }
}
