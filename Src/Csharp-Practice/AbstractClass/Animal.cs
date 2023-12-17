using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public string GetName() 
        { 
            return this.Name; 
        }

        public abstract void Eat();
    }
}
