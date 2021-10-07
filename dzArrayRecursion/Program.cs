using System;

namespace dzArrayRecursion
{
    class Program
    {
        // вывод массива с помощью рекурсии
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 1, 4, 5, 6, 7, 8 };

            Output(myArray,0);
            
        }

        static void Output(int [] array, int i)
        {
            Console.WriteLine(array[i]);
            if (i >= array.Length-1)
            {
                return;
            }
            i++;
            Output(array, i);
        }
    }
}
