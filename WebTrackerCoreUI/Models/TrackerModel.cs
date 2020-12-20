using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTrackerUI.Models
{
    public class TrackerModel
    {
        [Required]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Website URL")]
        [DataType(DataType.Url)]
        public string WebsiteURL { get; set; }
    }
}