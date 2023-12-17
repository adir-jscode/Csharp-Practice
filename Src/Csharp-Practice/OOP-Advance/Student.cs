using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advance
{
    public class Student : Person
    {
        private const string _idPrefix = "ST-"; // Can't change later
        private readonly int _id; // can be set or initialize within Constructor
        public Student(int id) : base(0)
        {
            _id = id;
        }

        

        public string GetStudentId() 
        {
            return _idPrefix + _id;
        }

        public double CalculateCgpa()
        {
            var cgpa = 0;
            //cgpa = 4.5 // got the data type 
            return cgpa;
        }

        public override string GetId() 
        {
            return GetStudentId();
        }
    }
}
