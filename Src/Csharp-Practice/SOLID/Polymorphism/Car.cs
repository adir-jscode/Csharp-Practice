using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Polymorphism
{
    public class Car : Vehcile
    {
        public string Name { get; set; }
        public override void Move()
        {
            Console.WriteLine($"{Name} Car is moving");
        }

        public void Move(int speed)
        {
            Console.WriteLine($"{Name} is moving at Speed {speed} ");
        }


    }
}
