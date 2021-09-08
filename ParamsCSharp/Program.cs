using System;

namespace ParamsCSharp
{
    class Program
    {
        static int Sum(int a, int b)
        {
            return a + b;

        }
        static int Sum(int a, int b, int c) // d e f g h 
        {
            return a + b + c;

        }

        // реализация Sum через params чтобы можно было добавлять большее количество элементов
        static int Sum(params int[] parameters)
        {
            int result = 0;
            for (int i = 0; i < parameters.Length; i++)
            {
                result += parameters[i];
            }
            return result;
        }
        // params указывается последним static int Sum(string str, params int[] parameters)   // int result = Sum("test", 3, 4, 4, 3, 2, 54);

        // пример с разными типами данных
        static void Foo(params object[] parameters)
        {
            string message = "Тип данных: {0}, значение: {1}";

            foreach (var item in parameters)
            {
                Console.WriteLine(message, item.GetType(), item);
            }
        }


        static void Main(string[] args)
        {
            int result = Sum(3, 4);

            int result3 = Sum(3, 4, 4);


            int result99 = Sum(3, 4, 4, 3, 2, 54);
            int result0 = Sum();

            Console.WriteLine(result);
            Console.WriteLine(result3);
            Console.WriteLine(result99);
            Console.WriteLine(result0);
            Foo("stroka",'$',332,33.33f, true);
        }
    }
}
