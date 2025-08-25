using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.Data.Models
{
    public class Stud_Course
    {
        [Key, Column(Order = 1)]
        public int stud_ID { get; set; }
        public Student Student { get; set; }

        [Key, Column(Order = 2)]
        public int Course_ID { get; set; }
        public Course Course { get; set; }

        [Range(0, 100)]
        public int? Grade { get; set; }
    }
}
