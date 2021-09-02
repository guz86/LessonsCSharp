using System;

namespace refHomeWrk
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5];
            int element = 10;
            Resize(ref myArray, element);
            int length = myArray.Length;
        }

        //Написать метод Resize изменяющий количество элементов массива(метод должен иметь возможность увеличить или уменьшить количество элментов массива)
        static void Resize(ref int[] arr, int element)
        {
            arr = new int[element];
        }


        //Написать методы для добавления элемента в начало массива, в конец массива и по указанному индексу
        //Написать методы для удаления первого элемента массива, последнего элемента массива и элемента по указанному индексу.









    }
}
