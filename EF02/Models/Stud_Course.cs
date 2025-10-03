using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Models
{
    [Table("Stud_Courses")]
    public class Stud_Course
    {
        [Key, Column(Order = 1)]
        public int stud_ID { get; set; }
        public Student Student { get; set; }

        [Key, Column(Order = 2)]
        public int Course_ID { get; set; }
        public Course Course { get; set; }

        public double Grade { get; set; }
    }
}
