using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COREMVC.Models
{
    public partial class RolesTable
    {
        [Key]
        public int id { get; set; }
        public string JobRoles { get; set; }
    }
}
