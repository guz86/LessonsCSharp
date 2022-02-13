using System;

namespace EnumSimple
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


                // дни недели
                DayOfWeek dayOfWeek = DayOfWeek.Monday;
                // узнаем тип данных
                //Type enumType = dayOfWeek.GetType();
                Type enumType = typeof(DayOfWeek);
                Console.WriteLine(Enum.GetUnderlyingType(enumType));

                //следующий день
                Console.WriteLine(GetNextDay(DayOfWeek.Friday));




                // к какому числу соотвествует день недели
                Console.WriteLine((DayOfWeek)3); // число 3 приводим к нашему enum

                // что делать если число выходит за пределы enum, пришло извне
                int day = 44;
                //Console.WriteLine((DayOfWeek)day);
                // тогда вернется просто число из int
                // проверка элемента в соотвествующем enum DayOfWeek
                if (Enum.IsDefined(typeof(DayOfWeek), (byte)day))
                {
                    dayOfWeek = (DayOfWeek)day;
                }
                else
                {
                    throw new Exception("Invalid DayofWeek day");
                }

                Console.WriteLine(dayOfWeek);
            }

            static DayOfWeek GetNextDay(DayOfWeek day)
            {
                if (day < DayOfWeek.Sunday)
                {
                   return day + 1;
                }

                return DayOfWeek.Monday;
            }
        }
    }
}
