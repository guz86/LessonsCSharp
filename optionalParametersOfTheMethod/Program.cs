using System;

namespace optionalParametersOfTheMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //int result = Sum(2, 4);
            int result = Sum(2, 4, true);
            Console.WriteLine(result);
        }
        static int Sum(int a, int b, bool Logging = false)
        {
            int result = a + b;

            if (Logging)
            {
                Console.WriteLine($"Сумма двух чисел {a} и {b} равна {result}");
            }

            return result;
        }
    }
}
