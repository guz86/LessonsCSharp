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
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp; 
        }
    }
}
