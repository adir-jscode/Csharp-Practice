using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advance
{
    
    public class Laptop
    {
        private IInternetService _internet;

        public Laptop(IInternetService internet)
        {
            _internet = internet;
        }

        public void BrowseWebsite()
        {
            _internet.EstablishConnection("adir", "adir12", "123");
        }
    }
}
