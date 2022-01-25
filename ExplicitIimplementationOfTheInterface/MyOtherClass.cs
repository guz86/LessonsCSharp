using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitIimplementationOfTheInterface
{
    // явная реализация
    class MyOtherClass : IFirstInterface, ISecondInterface
    {
        void IFirstInterface.Action()
        {
            Console.WriteLine("Action First");
        }

        void ISecondInterface.Action()
        {
            Console.WriteLine("Action Second");
        }
    }
}
