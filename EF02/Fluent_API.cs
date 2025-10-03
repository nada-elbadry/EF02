using EF02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02
{
    internal class Fluent_API
    {
    //    public class StudentConfig : IEntityTypeConfiguration<Student>
    //    {
    //        public void Configure(EntityTypeBuilder<Student> builder)
    //        {
    //            builder.ToTable("Students");
    //            builder.HasKey(s => s.ID);

    //            builder.Property(s => s.FName).IsRequired().HasMaxLength(50);
    //            builder.Property(s => s.LName).IsRequired().HasMaxLength(50);

    //            builder.HasOne(s => s.Department)
    //                   .WithMany(d => d.Students)
    //                   .HasForeignKey(s => s.Dep_Id);
    //        }
    //    }
    //    public class DepartmentConfig : IEntityTypeConfiguration<Department>
    //    {
    //        public void Configure(EntityTypeBuilder<Department> builder)
    //        {
    //            builder.ToTable("Departments");
    //            builder.HasKey(d => d.ID);

    //            builder.Property(d => d.Name).IsRequired().HasMaxLength(100);
    //        }
    //    }
    //    public class CourseConfig : IEntityTypeConfiguration<Course>
    //    {
    //        public void Configure(EntityTypeBuilder<Course> builder)
    //        {
    //            builder.ToTable("Courses");
    //            builder.HasKey(c => c.ID);

    //            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);

    //            builder.HasOne(c => c.Topic)
    //                   .WithMany(t => t.Courses)
    //                   .HasForeignKey(c => c.Top_ID);
    //        }
    //    }
    //    public class InstructorConfig : IEntityTypeConfiguration<Instructor>
    //    {
    //        public void Configure(EntityTypeBuilder<Instructor> builder)
    //        {
    //            builder.ToTable("Instructors");
    //            builder.HasKey(i => i.ID);

    //            builder.Property(i => i.Name).IsRequired().HasMaxLength(100);

    //            builder.HasOne(i => i.Department)
    //                   .WithMany(d => d.Instructors)
    //                   .HasForeignKey(i => i.Dept_ID);
    //        }
    //    }
    //    public class TopicConfig : IEntityTypeConfiguration<Topic>
    //    {
    //        public void Configure(EntityTypeBuilder<Topic> builder)
    //        {
    //            builder.ToTable("Topics");
    //            builder.HasKey(t => t.ID);

    //            builder.Property(t => t.Name).IsRequired().HasMaxLength(100);
    //        }
    //    }
    //    public class StudCourseConfig : IEntityTypeConfiguration<Stud_Course>
    //    {
    //        public void Configure(EntityTypeBuilder<Stud_Course> builder)
    //        {
    //            builder.ToTable("Stud_Courses");
    //            builder.HasKey(sc => new { sc.stud_ID, sc.Course_ID });

    //            builder.HasOne(sc => sc.Student)
    //                   .WithMany(s => s.Stud_Courses)
    //                   .HasForeignKey(sc => sc.stud_ID);

    //            builder.HasOne(sc => sc.Course)
    //                   .WithMany(c => c.Stud_Courses)
    //                   .HasForeignKey(sc => sc.Course_ID);
    //        }
    //    }
    //    public class CourseInstConfig : IEntityTypeConfiguration<Course_Inst>
    //    {
    //        public void Configure(EntityTypeBuilder<Course_Inst> builder)
    //        {
    //            builder.ToTable("Course_Instructors");
    //            builder.HasKey(ci => new { ci.inst_ID, ci.Course_ID });

    //            builder.HasOne(ci => ci.Instructor)
    //                   .WithMany(i => i.Course_Instructors)
    //                   .HasForeignKey(ci => ci.inst_ID);

    //            builder.HasOne(ci => ci.Course)
    //                   .WithMany(c => c.Course_Instructors)
    //                   .HasForeignKey(ci => ci.Course_ID);
    //        }
    //    }
    //    public class CompanyDbContext : DbContext
    //    {
    //        public DbSet<Student> Students { get; set; }
    //        public DbSet<Department> Departments { get; set; }
    //        public DbSet<Course> Courses { get; set; }
    //        public DbSet<Instructor> Instructors { get; set; }
    //        public DbSet<Topic> Topics { get; set; }
    //        public DbSet<Stud_Course> Stud_Courses { get; set; }
    //        public DbSet<Course_Inst> Course_Instructors { get; set; }

    //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //        {
    //            optionsBuilder.UseSqlServer("Server=.;Database=ITIDb;Trusted_Connection=True;TrustServerCertificate=True");
    //        }

    //        protected override void OnModelCreating(ModelBuilder modelBuilder)
    //        {
    //            modelBuilder.ApplyConfiguration(new StudentConfig());
    //            modelBuilder.ApplyConfiguration(new DepartmentConfig());
    //            modelBuilder.ApplyConfiguration(new CourseConfig());
    //            modelBuilder.ApplyConfiguration(new InstructorConfig());
    //            modelBuilder.ApplyConfiguration(new TopicConfig());
    //            modelBuilder.ApplyConfiguration(new StudCourseConfig());
    //            modelBuilder.ApplyConfiguration(new CourseInstConfig());
    //        }
    //    }
    }
}
