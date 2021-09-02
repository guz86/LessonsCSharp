using System;

namespace refHomeWrk
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] myArray = new int[5];
            int[] myArray = { 1, 2, 3, 66 };
            int element = 2;
            myArray = Resize(ref myArray, element);
            int length = myArray.Length;
        }

        //Написать метод Resize изменяющий количество элементов массива(метод должен иметь возможность увеличить или уменьшить количество элментов массива)
        static int[] Resize(ref int[] arr, int element)
        {
            int [] temparr = new int[element];
            int lengthArray = 0;
            if (element < arr.Length)
            {
                lengthArray = temparr.Length;
            }
            else
            {
                lengthArray = arr.Length;
            }

            for (int i = 0; i < lengthArray; i++)
            {
                  temparr[i] = arr[i];
            }
            return temparr;
        }

        // array.Resize




        //Написать методы для добавления элемента в начало массива, в конец массива и по указанному индексу
        //Написать методы для удаления первого элемента массива, последнего элемента массива и элемента по указанному индексу.









    }
}
