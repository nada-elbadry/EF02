using EF02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02
{
    public class CompanyDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Course_Inst> Course_Instructors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ITIDb;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Composite Keys
            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.stud_ID, sc.Course_ID });

            modelBuilder.Entity<Course_Inst>()
                .HasKey(ci => new { ci.inst_ID, ci.Course_ID });
        }
    }
}
