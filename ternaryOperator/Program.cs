using System;

namespace ternaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            // унарная операция - операция над одним объектом (операндом)
            a++;
            // бинарная операция
            int b = 0;
            int c = a + b;
            // тернарный оператор
            // первый операнд это условие ? второй операнд - если истина : третий операнд если ложь
            // конструкция if else только в более компактном виде для простых операций
            bool check = a == 1 ?  true  :  false;
            Console.WriteLine(check);


            // если вводим отрицательное то его обнуляем, если положительное оставляем
            int inputDate = Convert.ToInt32(Console.ReadLine());
            int outputDate = inputDate > 0 ? inputDate : 0;
            Console.WriteLine(outputDate);

        }
    }
}
