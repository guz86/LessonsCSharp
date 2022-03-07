using System;

namespace DelegatesExempleCodaza
{
    class Program
    {
        static void Main(string[] args)
        {
            // библиотека условно подключается к бирже и забирает от цену на акцию BAC
            // получив цену библиотека StockExchangeMonitor будет сообщать ее всем желающим
            // наше приложение тоже будет получать цену и будет выводить ее на консоль в реальном времени

            //создаем монитор
            StockExchangeMonitor stockExchangeMonitor = new StockExchangeMonitor();

            // регистрируем метод
            stockExchangeMonitor.PriceChangeHandler = ShowPrice;
            // запускаем
            stockExchangeMonitor.Start();


        }

        // метод который будет выводить текущую цену на консоль
        public static void ShowPrice(int price)
        {
            Console.WriteLine(price);
        }
    }
}
