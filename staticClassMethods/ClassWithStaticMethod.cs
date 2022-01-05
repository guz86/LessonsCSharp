using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticClassMethods
{
    class ClassWithStaticMethod
    {
        private static int _a;

        public static void Foo()
        {
            Console.WriteLine("Foo");
            _a = 5;
            Console.WriteLine(_a);
        }

        public void Bar()
        {
            Console.WriteLine("Bar");
            _a = 11;
            Console.WriteLine(_a);
            Foo();
        }


        private static int _b;
        // статические свойства
        public static int _B
        {
            get { return _b; }
            set { _b = value; }
        }



        // подсчет количества экземпляров/ пример 

        // конструктор, при вызыве увеличиваем статическое поле
        public ClassWithStaticMethod()
        {
            //counter++;
            // не на прямую а через свойство
            Counter++;
        }


        private static int counter;

        public static int Counter
        {
            get { return counter; }
            // убираем возможность внести изменения извне
            private set {  counter = value; }
        }

        public static int GetCounter()
        {
            return counter;
        }

        public int GetObjectCount()
        {
            return counter;
        }
        


    }
}
