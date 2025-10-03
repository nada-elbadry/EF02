using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string FName { get; set; }

        [Required, MaxLength(50)]
        public string LName { get; set; }

        public string Address { get; set; }
        public int Age { get; set; }

        [ForeignKey("Department")]
        public int Dep_Id { get; set; }
        public Department Department { get; set; }

        public ICollection<Stud_Course> Stud_Courses { get; set; }
    }
}
