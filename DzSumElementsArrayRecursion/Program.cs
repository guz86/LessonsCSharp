using System;

namespace DzSumElementsArrayRecursion
{
    class Program
    {
        // Найти сумму элементов массива с помощью рекурсии
        // Find the sum of array elements using recursion
        static void Main(string[] args)
        {
             int[] myArray  = {1,1,2 };
            SumArray(myArray);
            Console.WriteLine(SumArrayV2(myArray));
            Console.WriteLine(SumArrayV3(myArray));


        }
        static void SumArray(int [] array, int i = 0, int result = 0)
        {
            if (i < array.Length)
            {
                result += array[i];
                i++;

                SumArray(array, i, result);
            }
            else
            {
                Console.WriteLine(result);
            }


        }

        // вариант из урока
        // version from training

        // stack
        // 4 result=0 ↓
        // 3 result=2 ↓
        // 2 result=1+2 ↓
        // 1 result=1+3 ↓


        static int SumArrayV2(int[] array, int i = 0)
        {
            if (i>=array.Length)
            return 0;
            
            int result = SumArrayV2(array, i + 1);
            return array[i]+result;
        }

        static int SumArrayV3(int[] array, int i = 0)
        {
            if (i >= array.Length)
                return 0;

            return array[i] + SumArrayV2(array, i + 1);
        }
    }
}
