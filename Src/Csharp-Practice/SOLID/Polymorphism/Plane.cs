using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Polymorphism
{
    public class Plane : Vehcile
    {
        public string Name { get; set; }

        public override void Move()
        {
            Console.WriteLine($"{Name} Plane is Moving");
        }

        public void Move(int speed) 
        {
            Console.WriteLine($"{Name} is moving at speed {speed}");
        }
    }
}
