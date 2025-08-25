using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.Data.Models
{
    public class Instructor
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Range(1, double.MaxValue)]
        public decimal Salary { get; set; }

        [MaxLength(150)]
        public string Address { get; set; }

        [Range(0, double.MaxValue)]
        public decimal HourRateBouns { get; set; }

        [ForeignKey("Department")]
        public int Dept_ID { get; set; }
        public Department Department { get; set; }

        public ICollection<Course_Inst> Course_Instructors { get; set; }
    }
}
