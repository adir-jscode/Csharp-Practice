using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advance
{
    public class Internet7G : IInternetService
    {
        public void Connection()
        {
            Console.WriteLine("Connect To 7G");
        }

        public void Disconnect()
        {
            
        }

        public void EstablishConnection(string host, string username, string password)
        {
            Console.WriteLine("Established 7G");
            Connection();
        }
    }
}
