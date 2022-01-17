using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Employee_DB.Models
{
    public partial class Tableuser
    {
        [Key]
        public string Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmpId { get; set; }
        public string ContactNo { get; set; }
    }
}
