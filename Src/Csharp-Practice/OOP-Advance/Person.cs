using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advance
{
    public abstract class Person //Can't create instance or Object
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        protected int[] grades;

        public Person(int size) 
        {
            grades = new int[size];
        }

       

        public void SetGrades(int[] grades)
        {
            this.grades = grades;
        }

        public abstract string GetId();

        //Return Class

        //public Person GetNewPerson()
        //{
        //    return new Person(0);
        //}
    }
}
