using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tryy01.Models;

namespace EF02.ModelConfigration
{
    internal class DepartmentConfiguration: IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Department", "Sales");
            builder.HasKey(D => D.DeptId);
            builder.Property(D => D.DeptId).UseIdentityColumn(10, 10);
            builder.Property(D => D.DeptName)
            .HasColumnName("DepartmentName")
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .IsRequired(false)
            .HasDefaultValue("HR");
            builder.Property(D => D.DateOfCreation)
            //.IsRequired(false)
            .HasAnnotation("DataType", "DateTime")//EF Core will not use this for mapping
            //.HasDefaultValue(DateTime.Now)//Use DateTime.Now : Time Migration Created
            .HasDefaultValueSql("GETDATE()")//Use GETDATE() : Time Record Inserted
            .HasColumnType("DATETIME");
        }

       
    }
    
    }

