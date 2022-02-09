using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // обобщения, код будет одинаково работать с разными типами данных
            // избежать процессы упаковки и распаковки

            int a = 1, b = 2;
            Console.WriteLine($"a = {a}, b = {b}");

            Swap(ref a, ref b);
            Console.WriteLine($"a = {a}, b = {b}");


            string c = "C", d = "D";
            Console.WriteLine($"c = {c}, d = {d}");

            Swap(ref c, ref d);
            Console.WriteLine($"c = {c}, d = {d}");


            int result = Foo<int>();
            string result2 = Foo<string>();


            //
            //

            //обобщеные коллекции
            List<int> list = new List<int>();
            // класс некая обертка над массивом, внутри класса находится массив
            list.Add(1);
            list.Add(3);
            list.Add(2);
            Console.WriteLine(list[0]);
            List<string> listString = new List<string>();


            //
            MyList<int> myList = new MyList<int>();
            myList.Add(2);
            myList.Add(2);
            myList.Add(3);

            Console.WriteLine(myList[0]);
        }
        //static void Swap(ref int a, ref int b)
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        //static void Swap(ref double a, ref double b)
        //{
        //    double temp = a;
        //    a = b;
        //    b = temp;
        //}

        static T Foo<T>()
        {
            // вернуть дефолтное значения для типа данных   
            //return default;
            return default(T);
        }
    }
}
