﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weborb.Service;

namespace ResLink.BL.Models
{
    public class Complaint
    {
        [SetClientClassMemberName("objectId")]
        public string objectId { get; set; }

        [SetClientClassMemberName("created")]
        private DateTime DateCreated { get; set; }

        public string GetDateCreated { get { return DateCreated.ToString("dd MMMM yyyy"); } }

        [SetClientClassMemberName("complaintTitle")]
        public string ComplaintTitle { get; set; }

        [SetClientClassMemberName("complaintDescription")]
        public string ComplaintDescription { get; set; }

        [SetClientClassMemberName("complaintVote")]
        public int ComplaintVote { get; set; }

        [SetClientClassMemberName("student")]
        public Student Student { get; set; }


    }
}
