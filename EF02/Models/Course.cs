using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Models
{
    [Table("Courses")]
    public class Course
    {
        [Key]
        public int ID { get; set; }
        public int Duration { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        [ForeignKey("Topic")]
        public int Top_ID { get; set; }
        public Topic Topic { get; set; }

        public ICollection<Stud_Course> Stud_Courses { get; set; }
        public ICollection<Course_Inst> Course_Instructors { get; set; }
    }
}
