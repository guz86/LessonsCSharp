using System;

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
    }
}
