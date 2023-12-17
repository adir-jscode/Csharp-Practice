using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Audi : IVehiculo
    {
       
        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void EstablishEngine()
        {
            Console.WriteLine("AudiA7 Engine Installed");
        }

        public bool Fuel(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
