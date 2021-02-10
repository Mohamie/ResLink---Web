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
        [SetClientClassMemberName("objectId")]
        public string objectId { get; set; }


        [SetClientClassMemberName("fullNames")]
        public string FullNames { get; set; }


        [SetClientClassMemberName("lastName")]
        public string LastName { get; set; }


        [SetClientClassMemberName("studentNumber")]
        public int StudentNumber { get; set; }


        [SetClientClassMemberName("studentAccount")]

        public BackendlessUser StudentAccount { get; set; }


        [SetClientClassMemberName("gender")]
        public Gender Gender { get; set; }


    }
}
