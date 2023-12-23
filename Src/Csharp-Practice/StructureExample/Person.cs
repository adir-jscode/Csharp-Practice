using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureExample
{
    //Can't inherit, can use Interface
    public struct Person //Struct => Value type datatype => use stack , class => Reference type datatype => Heap memory 
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person( string name, int age) 
        {
            Name = name;
            Age = age;
        }

        public int RoundAge(int age)
        {
            return Age % 10 >=5 ? ((Age/10 + 1) *10) : (Age/10) *10;
        }
    }
}
