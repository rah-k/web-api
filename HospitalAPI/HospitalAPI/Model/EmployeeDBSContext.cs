using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Model
{
    public class EmployeeDBSContext:DbContext
    {
        public EmployeeDBSContext()
        {

        }
        public EmployeeDBSContext(DbContextOptions<EmployeeDBSContext>options):base(options)
        {

        }

        public virtual DbSet<Hospital> Hospital { get; set; }
        
    }
}
