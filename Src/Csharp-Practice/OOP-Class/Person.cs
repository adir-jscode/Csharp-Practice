using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Class //Namespace
{
    class Person
    {
       private string firstName; //field
       private string lastName;

        public string FirstName 
        {

            get 
            { 
                 return firstName;
            }   
                
        }

        public string LastName
        {

            get
            {
                return lastName;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    lastName = value;
                }
                else
                {
                    lastName += "Invalid or Empty";
                }
            }


        }

        public int age { get; set; } // Auto Property

        public Person() : this(string.Empty,string.Empty) { } //Empty Constructor

        public Person(string firstName, string lastName) //Parameterized Constructor
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

       public string GetName(string Separator)
        {
            string fullName = firstName + Separator + lastName;
            return fullName;
        }

        public string GetName(string [] Separator) // Method Overloading 
        {

            return GetName(Separator[0]);
        }
    }
}
