using System;

namespace DZsumOfNumbersRecurtion
{
    class Program
    {
        // найти сумму цифр числа с помощью рекурсии
        // find the sum of the numbers by recursion
        // 561  => 12
        static void Main(string[] args)
        {
            int numbers = 561;
            SumOfNumbersV1(numbers);
        }
        static void SumOfNumbersV1(int numbers)
        {
            string Str = Convert.ToString(numbers);

            int sum = 0;

            for (int i = 0; i < Str.Length; i++)
            {
                sum += int.Parse(Str[i].ToString());
            }
            Console.WriteLine(sum);
        }



    }
}
