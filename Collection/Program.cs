﻿using System;
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
            // лучше через if

            if (numbers.Remove(7)) // возращает true если находит и удаляет first occurence
            {
                // yes
            }

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

            // короткая запись
            var list1 = new List<string>() {"Hello", "HI"};

            // c#9
            List<string> list2 = new() { "Hello", "HI" };
            List<string> socialNetworks = new() { "YouTube", "Facebook", "Instagram" };
            List<int> numbers2 = new();

            // array List
            string[] food = new string[3];
            food[0] = "pizza";
            food[1] = "pasta";
            food[2] = "BORZH";

            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine(food[i]);
            }

            var foods = new List<string>(3) {"pizza","pasta" };
            foods.Add("Borzh");
            for (int i = 0; i < foods.Count; i++)
            {
                Console.WriteLine(foods[i]);
            }

            foods.Sort();
            foreach (string item in foods)
            {
                Console.WriteLine($"food - {item}");
            }
            foods.Reverse();
            // List to Array
            string[] foodArray = foods.ToArray();
            foreach (string item in foodArray)
            {
                Console.WriteLine($"arrayfood - {item}");
            }

        }

        
        //Queue ;
        //Stack ;
        //Dictionary

    }
}
