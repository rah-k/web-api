using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace crud_usingDB.Models
{
    public partial class TblItems
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ItemCode { get; set; }
        public string ImagePath { get; set; }
        public DateTime? LastUpdated { get; set; }
        public int? Count { get; set; }
    }
}
