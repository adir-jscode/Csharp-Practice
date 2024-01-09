using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Encapsulation
{
    //Isolation Or Wrap within class=> Encapsulation 
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set;}

        public void CalucateCgpa()
        {

        }
    }

    public class Teacher
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }

        public void GiveGrade()
        {

        }
    }
}
