using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticClassConstructor
{
    class StaticConstructor
    {

        public StaticConstructor()
        {
            Console.WriteLine("Обычный конструктор");
        }
        // перегрузка
        public StaticConstructor(int a)
        {
            Console.WriteLine(a);
            
        }

        // статический конструктор
        // модификаторы доступа не используются
        // только один в классе
        // не может принимать параметров
        static StaticConstructor()
        {
            Console.WriteLine("Статический конструктор");
            
        }

        // статический метод
        public static void Foo()
        {
            Console.WriteLine("Foo");
        }
    }
}
