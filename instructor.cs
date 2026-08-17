using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_day_2_entityf_ramework
{
    public class instructor
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string specialization { get; set; }

        public ICollection<course> Courses { get; set; }

    }
}
