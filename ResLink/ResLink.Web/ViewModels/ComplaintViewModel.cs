using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResLink.Web.ViewModels
{
    public class ComplaintViewModel
    {
        [Required]
        public string ComplaintTitle { get; set; }

        [Required]
        public string ComplaintDescription { get; set; }
        [Required]
        public string ComplaintCategory { get; set; }

        [Required]
        public string ComplaintAlertSeverity { get; set; }
    }
}
