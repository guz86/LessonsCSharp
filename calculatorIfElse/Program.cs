using System;

namespace calculatorIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Введите первое число: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите знак: * / % + - ");
                char symbol = Convert.ToChar(Console.ReadLine());
                Console.Write("Введите второе число: ");
                double b = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                Console.WriteLine("Вычисляем: " + a + symbol + b);

                if (symbol == '*')
                {
                    result = a * b;
                }
                else if (symbol == '/' && b != 0)
                {
                    result = a / b;
                }
                else if (symbol == '/' && b == 0)
                {
                    Console.WriteLine("На 0 делить нельзя.");

                }
                else if (symbol == '%')
                {
                    result = a % b;
                }
                else if (symbol == '+')
                {
                    result = a + b;
                }
                else if (symbol == '-')
                {
                    result = a - b;
                }
                else
                {
                    Console.WriteLine("Неизвестное действие");
                }

                Console.WriteLine("Результат: " + result);

                Console.ReadKey();
            }
            
        }
    }
}
