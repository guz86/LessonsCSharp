using System;

namespace refHomeWrk
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] myArray = new int[5];
            int[] myArray = { 1, 2, 3, 66 };
            int element = 12;
            MyResize(ref myArray, element);
            int length = myArray.Length;



            string[] Array2 = { "DDD", "GD", "FDD", "SD" };
            //Array.Resize(ref Array2,20);
            Resize(ref Array2, element);
            int length2 = Array2.Length;

            int elementValue = 55;
            AddElementBegin(ref myArray, elementValue);
            int length3 = myArray.Length;


            int[] myArray2 = { 1, 1, 1, 2, 3, 66 };
            int elementValue2 = 35;
            int elementIndex = myArray2.Length;
            AddElementIndex(ref myArray2, elementIndex, elementValue2);
            int length4 = myArray2.Length;


        }

        //Написать метод Resize изменяющий количество элементов массива(метод должен иметь возможность увеличить или уменьшить количество элментов массива)
        static void MyResize(ref int[] arr, int element)
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
            arr = temparr;
        }

        static void Resize<T>(ref T[] arr, int element)
        {
            T[] temparr = new T[element];
            for (int i = 0; i < arr.Length && i < temparr.Length; i++)
            {
                temparr[i] = arr[i];
            }
            arr = temparr;
        }


        //Написать методы для удаления первого элемента массива, последнего элемента массива и элемента по указанному индексу.

        // 1 Написать методы для добавления элемента по указанному индексу
        static void AddElementIndex(ref int[] arr, int index, int value)
        {     
            int[] tempArray = new int[arr.Length + 1];
            for (int i = 0, j =0 ; i < arr.Length + 1;  i++, j++)
            {
                if (i == index)
                {
                    tempArray[index] = value;
                    j--;
                }
                else
                {
                     tempArray[i] = arr[j];
                }
            }
            arr = tempArray;
        }

        // 2 Написать методы для добавления элемента в начало массива
        static void AddElementBegin(ref int[] arr, int elementValue)
        {
            int[] tempArray = new int[arr.Length+1];
            tempArray[0] = elementValue;

            for (int i = 1; i < arr.Length; i++)
            {
                tempArray[i] = arr[i];
            }
            arr = tempArray;
        }

        









    }
}
