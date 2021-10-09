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
            string numbers2 = "561";
            SumOfNumbersV1(numbers);
            SumOfNumbersV2(numbers);
            Console.WriteLine(SumOfNumbersV3(numbers2));
            SumOfNumbersLesson(numbers);

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

        static void SumOfNumbersV2(int numbers, int sum = 0, int i = 0)
        {

            string Str = Convert.ToString(numbers);

            if (i < Str.Length)
            {
                sum += int.Parse(Str[i].ToString());
                i++;
                SumOfNumbersV2(numbers, sum, i);
            }
            else
            {
                Console.WriteLine(sum);
            }
            


        }
 
        static int SumOfNumbersV3(string num) => num.Length > 0 ? Convert.ToInt32(num[0] - '0') + SumOfNumbersV3(num[1..]) : 0;
        static void SumOfNumbersLesson(int numbers)
        {

        }

    }
}
