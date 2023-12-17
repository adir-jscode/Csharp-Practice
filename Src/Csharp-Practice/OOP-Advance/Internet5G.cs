using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advance
{
    public class Internet5G : IInternetService
    {
        public void EstablishConnection(string host, string username, string password)
        {
            Console.WriteLine("Established 5G");
        }
    }
}
