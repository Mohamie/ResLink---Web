using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResLink.Web.ViewModels
{
    public class EventViewModel
    {
        [Required]
        public string EventTitle { get; set; }

        [Required]
        public string EventDescription { get; set; }
        [Required]
        public string EventCategory { get; set; }

    }
}
