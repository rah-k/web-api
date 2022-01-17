using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace crud_usingDB.Models
{
    public partial class GY_DBContext : DbContext
    {
       
        public GY_DBContext()
        {
            
        }

        public GY_DBContext(DbContextOptions<GY_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblItems> TblItems { get; set; }
        public virtual DbSet<TblUsers> TblUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=GY_DB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblItems>(entity =>
            {
                entity.ToTable("tblItems");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblUsers>(entity =>
            {
                entity.ToTable("tblUsers");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
