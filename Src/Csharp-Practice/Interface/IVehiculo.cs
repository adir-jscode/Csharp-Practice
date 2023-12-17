using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IVehiculo
    {
        void Drive();
        bool Fuel(int amount);

        void EstablishEngine();
    }
}
