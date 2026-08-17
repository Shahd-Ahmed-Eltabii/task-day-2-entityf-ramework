using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_day_2_entityf_ramework
{
    public class student
    {
        public int Id { get; set; }
        public string fullname { get; set; }
        public string Email { get; set; }
        public int age { get; set; }
        public int percent { get; set; }
        public ICollection<course> Courses { get; set; } 


    }
}
