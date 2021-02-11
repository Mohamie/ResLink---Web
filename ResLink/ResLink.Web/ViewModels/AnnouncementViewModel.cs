using System;
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
        [Required]
        public string AnnouncementCategory { get; set; }

        [Required]
        public string AnnouncementAlertSeverity { get; set; }

    }
}
