using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Advance
{
    public interface IInternetService
    {
        void EstablishConnection(string host,string username,string password);
    }
}
