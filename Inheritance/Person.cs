using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Person
    {
        public string FirsName { get; set; }
        public string LastName { get; set; }

        public void PrintFirstName()
        {
            Console.WriteLine($"Имя: {FirsName}");
        }
    }
}
