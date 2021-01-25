using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weborb.Service;

namespace ResLink.BL.Models
{
    public class Attendance
    {
        [SetClientClassMemberName("objectId")]
        public string ObjectID { get; set; }

        [SetClientClassMemberName("student")]
        public List<Student> Student { get; set; }


        [SetClientClassMemberName("meeting")]
        public Meeting Meeting { get; set; }
    }
}
