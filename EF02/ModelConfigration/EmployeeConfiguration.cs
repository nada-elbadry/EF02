using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Tryy01.Models;

namespace EF02.ModelConfigration
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            //modelBuilder.Entity<Employee>().ToTable("EmployeeTable");
           builder.HasKey(E => E.EmpId);
            //Identity Constraint Comes From Conventions(1,1)
            //builder.Property("EmpId");//Maybe throw exception if property not found
            //builder.Property<int>("Empid");//Will Define Shadow Property if property not found[Exist only in database]
            //builder.Property(typeof(Int32), "EMPID");//Will Define Shadow Property if property not found[Exist only in database]
           builder.Property(E => E.EmpId).UseIdentityColumn(10, 10);//Ef Core 5.0+

           builder.Property(E => E.EmpName).HasColumnName("EmployeeName").HasColumnType("VARCHAR").HasMaxLength(50).IsRequired(false);
           builder.Property(E => E.Salary).HasPrecision(10, 2);
           builder.ToTable(T => T.HasCheckConstraint("Check-Employee-Age-Range", "[Age] Between 22 And 40"));
           builder.ToTable(T => T.HasCheckConstraint("CheckAllowed_Employee_Age", "[Age] IN (24,26,28,30)"));
            //builder.ToTable(T => T.HasCheckConstraint("CheckAllowed_Employee_Age", "[Age] Not IN (24,26,28,30)"));
           builder.Property(E => E.Email).IsRequired();
           builder
           .ToTable(T => T.HasCheckConstraint("Check_Employee_Email", "[Email] like '%@%.%'"));
           builder
                .Ignore(E => E.UserName);//Ignore Property Mapping 
        }
    }
}
