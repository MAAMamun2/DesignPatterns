using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class OracelConnection : IDatabaseConnection
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to Oracel Database");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnecting to Oracel Database");
        }
    }
}
