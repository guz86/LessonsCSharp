using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Security : Person
    {
        public void Guard()
        {
            Console.WriteLine("Охраняю");
        }
    }
}
