using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tryy01.Models
{
    //Model or Entity or POCO Class or Domain Class
    //First way of mapping by Conventions

    // [Table("EmployeeTable")] //Data Annotation
    internal class Employee
    {
        //[Required] => Validation value Required at runtime[Mapped to Database]
        //required Keyword =>[C# 11 feature | .Net 7 feature ] Ensure Non-Null value at Compile Time[Not Mapped to Database]
        /*
        public int Id { get; set; }
        //public Numiric property Named As Id Or EmployeeId
        //Automaticly Assumed To Be Primary Key Of This Table With Identity Constraints
        public string? Name { get; set; }
        //? - Nullable Reference Type
        //sTRING?->Mapped To NVARCHAR(MAX) NULL
        public decimal Salary { get; set; }
        //value type are non-nullable by default
        //Salary ->Mapped To DECIMAL(18,2) NOT NULL
        public int Age { get; set; }
        */

        //[Key]//Data Annotation
        public int EmpId { get; set; }

       // [Column(name:"EmployeeName", TypeName = "VARCHAR")]
        //[MaxLength(50 , ErrorMessage = "Name Cannot Exceed 50 Chars")]//Message Application Validation
        //[MinLength(3,ErrorMessage ="Name Must be At least 3 Char")]//Application Validation
        //[StringLength(50,MinimumLength =3,ErrorMessage ="Name Must be Between 3 to 50 Chars")]//[Min, Message Application Validation]
       // [Length(3,50)]//[Min, Max, Message EF Core Validation]]Will not mapped to databse
        public string? EmpName { get; set; }

        // [Column(TypeName = "DECIMAL(10,2)")]
     //   [Precision(10,2)]
        public decimal Salary { get; set; }
        //[Range(22,40)]
        //[AllowedValues(24,26,28,30)]
        //[DeniedValues]
        public int Age { get; set; }

        //[Required]
        //[EmailAddress]
        //[DataType(DataType.EmailAddress)]//UI hint to display email address [Frontend]
        public string Email { get; set; }
        //[DataType(DataType.Password)]//UI hint to display password [Frontend]]
        //public string? Password { get; set; }
        //[Required]
        //[Phone]//Application Validation
        //[DataType(DataType.PhoneNumber)]//UI hint to display phone number [Frontend]
        public string PhoneNumber { get; set; }
        //[NotMapped]//Ignore this property
        public string UserName => Email.Split('@')[0];

    }
}
