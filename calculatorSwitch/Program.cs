using System;

namespace calculatorSwitch
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                double a;
                char symbol;
                double b;

                Console.Clear();


                try
                {
                    Console.Write("Введите первое число: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите знак: * / + - ");
                    symbol = Convert.ToChar(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    b = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Вы ввели не верные данные!");
                    Console.ReadLine();
                    continue;
                }



                double result = 0;

                Console.WriteLine("Вычисляем: " + a + symbol + b);


                switch (symbol)
                {
                    case '*':
                        result = a * b;
                        break;
                    case '/':
                        if (b != 0)
                        {

                            result = a / b;
                        }
                        else
                        {
                            Console.WriteLine("На ноль делить нельзя!");
                        }
                        break;

                    case '+':
                        result = a + b;
                        break;

                    case '-':
                        result = a - b;
                        break;

                    default:
                        Console.WriteLine("Введен не верный символ!");
                        break;
                }



                Console.WriteLine("Результат: " + result);

                Console.ReadKey();
            }
        }
    }
}
