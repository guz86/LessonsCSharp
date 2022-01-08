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
        public static string connectionString = "local DB";

        public void GetInfo()
        {
            Console.WriteLine(connectionString);
        }
    }
}
