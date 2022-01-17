using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace crud_usingDB.Models
{
    public partial class TblUsers
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public bool? IsAdmin { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
