using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_day_2_entityf_ramework
{
    public class course
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int durationInHours { get; set; }
        public int instructorId { get; set; }
        public ICollection<student> Students { get; set; }
        public instructor instructor { get; set; }

    }
}
