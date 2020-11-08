using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COREMVC.Models
{
    public partial class DepartmentTable
    {
        [Key]
        public int id { get; set; }
        public string Department { get; set; }
    }
}
