using System;

namespace dbConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbRepository = new DbRepository();
            dbRepository.GetInfo();
        }
    }
}
