using System;

namespace calculatorIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double a = Convert.ToDouble ( Console.ReadLine());
            Console.Write("Введите знак: * / % + - ");
            char symbol = Convert.ToChar( Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b = Convert.ToDouble (Console.ReadLine());

            double result = 0;

            Console.WriteLine("Вычисляем: " + a + symbol + b);

            if (symbol == '*')
            {
                result = a * b;
            }
            else if (symbol == '/')
            {
                result = a / b;
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

            Console.WriteLine("Результат: "+ result);
        }
    }
}
