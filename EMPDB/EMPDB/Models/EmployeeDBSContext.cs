using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EMPDB.Models
{
    public partial class EmployeeDBSContext : DbContext
    {
        public EmployeeDBSContext()
        {
        }

        public EmployeeDBSContext(DbContextOptions<EmployeeDBSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CrudTable> CrudTable { get; set; }

        
    }
}
