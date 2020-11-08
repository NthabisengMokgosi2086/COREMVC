using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COREMVC.Models
{
    public partial class RegistrationTable
    {
        
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string JobRole { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string EducatiionField { get; set; }
        public string Age { get; set; }
    }
}
