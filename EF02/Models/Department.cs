using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Models
{
    [Table("Departments")]
    public class Department
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public int Ins_ID { get; set; }
        public DateTime HiringDate { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Instructor> Instructors { get; set; }
    }
}
