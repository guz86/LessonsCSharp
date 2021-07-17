using System;

namespace theSumAndNumberOfEvenAndOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startDigit;
            int endDigit;

            uint evenCount = 0;
            uint oddCount = 0;

            int evenSum = 0;
            int oddSum = 0;

            Console.Write("Введите с какого числа будем считать: ");
            startDigit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите до какого числа будем считать: ");
            endDigit =  Convert.ToInt32(Console.ReadLine());
            
            
            while (startDigit <= endDigit)
            {
                if (startDigit % 2 == 0)
                {
                    //Console.WriteLine("Четное число "+ startDigit);
                    evenCount++;
                    evenSum += startDigit;
                }
                else
                {                
                    //Console.WriteLine("Нечетное число "+ startDigit);
                    oddCount++;
                    oddSum += startDigit;
                    
                }
                

                startDigit++;

                
            }
             
            Console.WriteLine("Количество четных: "+ evenCount);
            Console.WriteLine("Количество нечетных: " + oddCount);

            Console.WriteLine("Сумма четных: " + evenSum);
            Console.WriteLine("Сумма нечетных: " + oddSum);
        }
    }
}
