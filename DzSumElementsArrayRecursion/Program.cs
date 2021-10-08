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

        static int SumArrayV2(int[] array, int i = 0)
        {
            if (i>=array.Length)
            return 0;
            
            int result = SumArrayV2(array, i + 1);
            return array[i]+result;
        }
    }
}
