using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Models
{
    [Table("Course_Instructors")]
    public class Course_Inst
    {
        [Key, Column(Order = 1)]
        public int inst_ID { get; set; }
        public Instructor Instructor { get; set; }

        [Key, Column(Order = 2)]
        public int Course_ID { get; set; }
        public Course Course { get; set; }

        public string Evaluate { get; set; }
    }
}
