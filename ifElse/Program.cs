using System;
using System.Threading.Tasks;
using System.Threading;

namespace ifElse
{
    class Program
    {
        static void Main(string[] args)
        {
            IfelseBuy();
        }

        static public void IfelseOne()
        {
            bool isInfected;
            Random rand = new Random();

            // isInfected = rand.Next(0, 2) == 0;

            if (rand.Next(0, 2) == 0)
            {
                Console.WriteLine("Вы подхватили инфекцию!");
            }
            else
            {
                Console.WriteLine("Вы здоровы!");
            }
        }

        static public void IfelseBuy()
        {
            int money = 100; 
            int minPrice = 20;

            Console.WriteLine("Введите цену:");
            int price = Convert.ToInt32(Console.ReadLine());


            // ..........20..................100.............
            // логическое && || и !


            // все товары от 20 до 100 рублей
            // логическое &&

            if (price >= minPrice && price <= money) // (minPrice <= price && price <= money)
            {
                Console.WriteLine("Покупаем");
            }
            else
            {
                Console.WriteLine("Останемся без покупок");
            }

            // товары меньше 20 рублей или товары больше 100 рублей нам не нужны
            // логическое ||

            if (price < minPrice || price > money)
            {
                Console.WriteLine("Не покупаем!");
            }
            else
            {
                Console.WriteLine("Берем");

            }



            // все товары кроме товаров меньше 20 рублей и товаров больше 100 рублей
            // ! 

            if (!(price < minPrice || price > money))
            {
                Console.WriteLine("Забираем!");
            }
            else
            {
                Console.WriteLine("Уходим");

            }

        }
    }
}
