using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Polymorphism
{
    public class Vehcile
    {
        public virtual void Move()
        {
            Console.WriteLine("Moving");
        }
    }
}
