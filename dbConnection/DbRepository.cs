using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbConnection
{
    class DbRepository
    {
        // поле. строка подключения к бд
        //public static string connectionString = "local DB";
        public static string connectionString;

        static DbRepository()
        {
            var configurationManager = new ConfigurationManager();
            connectionString = configurationManager.GetConnectionString();
        }

        public void GetInfo()
        {
            Console.WriteLine(connectionString);
        }
    }
}
