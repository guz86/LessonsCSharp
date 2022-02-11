using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // информация о нажатой клавише на клавиатуре
                ConsoleKey consoleKey = Console.ReadKey().Key;
                Console.Clear();
                Console.WriteLine(consoleKey+"\t"+(int)consoleKey);
                if (consoleKey == ConsoleKey.Enter)
                {
                    Console.WriteLine($"Нажата клавиша {ConsoleKey.Enter}");
                }

            }
        }
    }
}
