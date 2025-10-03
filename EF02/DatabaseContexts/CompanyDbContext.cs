using EF02.ModelConfigration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Tryy01.Models;

namespace Tryy01.DatabaseContexts
{
    internal class CompanyDbContext :DbContext
    {
        public CompanyDbContext():base()
        {
                
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=CompanyG03;Trusted_Connection=True;TrustServerCertificate=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfiguration());
            //modelBuilder.ApplyConfiguration<Department>(new DepartmentConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //Automatically Apply All Fluent API Configration From Separated Classes[IEntityTypeConfiguration<T>]
            #region Employee Entity
            // //modelBuilder.Entity<Employee>().ToTable("EmployeeTable");
            //builder.HasKey(E => E.EmpId);
            // //Identity Constraint Comes From Conventions(1,1)
            // //builder.Property("EmpId");//Maybe throw exception if property not found
            // //builder.Property<int>("Empid");//Will Define Shadow Property if property not found[Exist only in database]
            // //builder.Property(typeof(Int32), "EMPID");//Will Define Shadow Property if property not found[Exist only in database]
            //builder.Property(E => E.EmpId).UseIdentityColumn(10, 10);//Ef Core 5.0+

            //builder.Property(E => E.EmpName).HasColumnName("EmployeeName").HasColumnType("VARCHAR").HasMaxLength(50).IsRequired(false);
            //builder.Property(E => E.Salary).HasPrecision(10, 2);
            //builder.ToTable(T => T.HasCheckConstraint("Check-Employee-Age-Range", "[Age] Between 22 And 40"));
            //builder.ToTable(T => T.HasCheckConstraint("CheckAllowed_Employee_Age", "[Age] IN (24,26,28,30)"));
            // //builder.ToTable(T => T.HasCheckConstraint("CheckAllowed_Employee_Age", "[Age] Not IN (24,26,28,30)"));
            //builder.Property(E => E.Email).IsRequired();
            //builder
            //.ToTable(T => T.HasCheckConstraint("Check_Employee_Email", "[Email] like '%@%.%'"));
            //builder
            //     .Ignore(E => E.UserName);//Ignore Property Mapping 
            #endregion

            #region Department
            //modelBuilder.Entity<Department>(D =>
            //{
            //    D.ToTable("Department", "Sales");
            //    D.HasKey(D => D.DeptId);
            //    D.Property(D=> D.DeptId).UseIdentityColumn(10, 10);
            //    D.Property(D => D.DeptName)
            //    .HasColumnName("DepartmentName")
            //    .HasColumnType("varchar")
            //    .HasMaxLength(50)
            //    .IsRequired(false)
            //    .HasDefaultValue("HR");
            //    D.Property(D => D.DateOfCreation)
            //    //.IsRequired(false)
            //    .HasAnnotation("DataType", "DateTime")//EF Core will not use this for mapping
            //    //.HasDefaultValue(DateTime.Now)//Use DateTime.Now : Time Migration Created
            //   // .HasComputedColumnSql("GETDATE()")//Use GETDATE() : Time Row Inserted calculated by sql server evry time you query DateOfCreation
            //    .HasDefaultValueSql("GETDATE()");//Get Current DateTime when Row|Record Inserted
            //    D.Ignore(D => D.Serial);    
            //});


            #endregion
        }
        //public DbSet<Employee> Employees { get; set; }
        //public DbSet<Department> Departments { get; set; }

        //public DbSet<Product> EmployeeProjects { get; set; }

        public DbSet<Employee> EmployeeTable { get; set; }
    }
}
