<<<<<<< HEAD
﻿using System;
=======
﻿using ResLink.BL.Models;
using System;
>>>>>>> 128f951df458f3e953548bd07cf765b6eec41e9c
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResLink.Web.ViewModels
{
    public class AnnouncementViewModel
    {

        [Required]
        public string AnnouncementTitle { get; set; }

        [Required]
        public string AnnouncementDescription { get; set; }
       
        public AlertSeverity AnnouncementSeverity { get; set; }

    }
}
