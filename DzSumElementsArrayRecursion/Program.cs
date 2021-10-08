using System;

namespace DzSumElementsArrayRecursion
{
    class Program
    {
        // Найти сумму элементов массива с помощью рекурсии
        // Find the sum of array elements using recursion
        static void Main(string[] args)
        {
             int[] myArray  = {1,1,3,3,3,5,6,2,3,5 };
            SumArray(myArray); 
            
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
    }
}
