using System;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            // List ; однотипные объекты
            List<int> numbers = new List<int>(3);
            //var numbers2 = new List<int>(5);
            numbers.Add(5);
            numbers.Add(2);

            int[] arrayAdd = { 1, 2, 56, 7, 5 };
            numbers.AddRange(arrayAdd);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"{i} элемент List  = {numbers[i]}");
            }

            numbers.RemoveAt(2);
            // первый попавшийся
            numbers.Remove(5);

            foreach (var item in numbers)
            {
                Console.WriteLine($"элемент List  = {item}");
            }

            Console.WriteLine($"Индекс элемента 56 - {numbers.IndexOf(56)}");

            numbers.Insert(1, 100000);

            foreach (var item in numbers)
            {
                Console.WriteLine($"элемент List  = {item}");
            }
        }


        //Queue ;
        //Stack ;
        //Dictionary

    }
}
