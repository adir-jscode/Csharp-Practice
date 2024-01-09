using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkExample
{
    //EF is a ORM -> Object Relational Model
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cgpa { get; set; }
        public DateTime DateOfBirth { get; set; }

        public List<CourseStudent> Courses { get; set; }
    }
}
