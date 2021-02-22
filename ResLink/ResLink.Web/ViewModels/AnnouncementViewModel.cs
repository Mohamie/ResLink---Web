using System;
﻿using ResLink.BL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResLink.Web.ViewModels
{
    public class AnnouncementViewModel
    {

        public string objectId { get; set; }

        [Required]
        public string AnnouncementTitle { get; set; }

        [Required]
        public string AnnouncementDescription { get; set; }

        public AlertSeverity AnnouncementSeverity { get; set; }

    }
}
