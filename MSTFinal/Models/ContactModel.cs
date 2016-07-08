using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MSTFinal.Models
{
    public class ContactModel
    {
        [Required]
        public string Name { get; set; }

        public string EmailAddress { get; set; }

        public string MobileNumber { get; set; }

        public string Message { get; set; }
    }
}