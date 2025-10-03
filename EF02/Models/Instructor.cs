using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Models
{
    [Table("Instructors")]
    public class Instructor
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public decimal Salary { get; set; }
        public string Address { get; set; }
        public decimal HourRate { get; set; }
        public decimal Bonus { get; set; }

        [ForeignKey("Department")]
        public int Dept_ID { get; set; }
        public Department Department { get; set; }

        public ICollection<Course_Inst> Course_Instructors { get; set; }
    }
}
