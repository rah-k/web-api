﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EmployeeDetails.Models
{
    public partial class Biodata
    {   
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string City { get; set; }
    }
}
