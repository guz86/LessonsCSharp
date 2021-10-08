using System;

namespace dzArrayRecursion
{
    class Program
    {
        // вывод массива с помощью рекурсии
        // array output by recursion
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 1, 4, 5, 6, 7, 8 };

            Output(myArray);
            
        }

        static void Output(int [] array, int i = 0)
        {
            //
            //if (i >= array.Length-1)
            //{
            //    return;
            //}
            //i++;
            //Output(array, i);

            if (i < array.Length)
            {
                Console.WriteLine(array[i]);
                Output(array, i+1);
            }

        }
    }
}
