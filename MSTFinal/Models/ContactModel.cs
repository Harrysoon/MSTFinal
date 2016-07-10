using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MSTFinal.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage ="Name is required")]
        [Placeholder("Name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Email Address is required")]
        [EmailAddress]
        [Placeholder("Email Address")]
        public string EmailAddress { get; set; }

        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "A message must be entered")]
        [StringLength(10000, MinimumLength = 10, ErrorMessage = "Please enter a longer message")]
        [DataType(DataType.MultilineText)]
        [Placeholder("Message")]
        public string Message { get; set; }
    }
}