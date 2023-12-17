using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Car : IVehiculo
    {
        private IVehiculo _veiculo;
        public int Octnen { get; set; }

        public Car(int fuel) 
        { 
            this.Octnen = fuel;
        }
        public Car(IVehiculo veiculo)
        {
            _veiculo = veiculo;
        }
        public void Drive()
        {
            if(this.Octnen <= 0)
            {
                Console.WriteLine("Not Driving");
            }
            else
            {
                Console.WriteLine("Driving");
            }
        }

        public bool Fuel(int amount)
        {
            this.Octnen += amount;
            return true;
        }

        public void EstablishEngine()
        {
           _veiculo.EstablishEngine();
        }
    }
}
