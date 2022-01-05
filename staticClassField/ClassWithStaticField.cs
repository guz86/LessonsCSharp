using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticClassField
{
    class ClassWithStaticField
    {
        // Статические поля класса
        //public int a;
        private static int _b;

        public void SetB(int b)
        {
            // ClassWithStaticField.b = b;
            _b = b;
        }

        public void PrintB()
        {
            Console.WriteLine(_b);
        }

    }


}
