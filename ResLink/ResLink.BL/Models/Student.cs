//using BackendlessAPI;
using BackendlessAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weborb.Service;
//using Weborb.Service;

namespace ResLink.BL.Models
{
    public class Student
    {
        [SetClientClassMemberName("objectID")]
        public int ObjectID { get; set; }


        [SetClientClassMemberName("fullNames")]
        public int FullNames { get; set; }


        [SetClientClassMemberName("lastName")]
        public int LastName { get; set; }


        [SetClientClassMemberName("studentNumber")]
        public int StudentNumber { get; set; }


        [SetClientClassMemberName("studentAccount")]

        public BackendlessUser StudentAccount { get; set; }


        [SetClientClassMemberName("gender")]
        public Gender Gender { get; set; }


    }
}
