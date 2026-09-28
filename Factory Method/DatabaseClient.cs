using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class DatabaseClient
    {
        private readonly IDatabaseConnection connection;

        public DatabaseClient(IDatabaseConnectionFactory factory)
        {
            connection = factory.CreateConnection();
        }
        public void UseDatabase()
        {
            connection.Connect();
            connection.Disconnect();
        }
    }
}
