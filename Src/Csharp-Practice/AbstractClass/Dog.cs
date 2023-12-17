using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine(Name + " is Eating");
        }
    }
}
