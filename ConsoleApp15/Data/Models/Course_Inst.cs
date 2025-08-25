using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.Data.Models
{
    public class Course_Inst
    {
        [Key, Column(Order = 1)]
        public int inst_ID { get; set; }
        public Instructor Instructor { get; set; }

        [Key, Column(Order = 2)]
        public int Course_ID { get; set; }
        public Course Course { get; set; }

        [Range(1, 10)]
        public int? Evaluate { get; set; }
    }
}
