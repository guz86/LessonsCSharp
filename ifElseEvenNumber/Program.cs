using System;

namespace ifElseEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int enterNumber;
            Console.Write("Введите число: ");
            enterNumber = Convert.ToInt32( Console.ReadLine());
            if (enterNumber % 2 == 0 )
            {
                Console.WriteLine("Это четное число!");
            }
            else
            {
                Console.WriteLine("Это нечетное число!");
            }
        }
    }
}
