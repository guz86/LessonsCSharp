using System;

namespace MultiplicationTables
{
    class Program
    {
        static void Main(string[] args)
        {
            WithoutArrays();
        }
        static public void WithoutArrays()
        {
            // таблица умножения 2 на 2 без массивов
            int x1_1, x1_2;
            int x2_1, x2_2;

            x1_1 = 1 * 1; x1_2 = 1 * 2;
            x2_1 = 2 * 1; x2_2 = 2 * 2;

            Console.WriteLine("\t1 \t2");
            Console.WriteLine($"1\t{x1_1}\t{x1_2}");
            Console.WriteLine($"2\t{x2_1}\t{x2_2}");
            
        }
    }
}
