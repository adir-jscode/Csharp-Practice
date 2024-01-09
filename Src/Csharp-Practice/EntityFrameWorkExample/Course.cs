using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkExample
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public uint Duration { get; set; }

        public List<Topic>? Topic { get; set; }

        public List<CourseStudent> Students { get; set; }
    }
}
