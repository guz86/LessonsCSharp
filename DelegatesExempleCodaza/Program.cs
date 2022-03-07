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

            // пояснение.
            // данном случае я не передаю в свойство значение,
            // а делаю вызов метода, ссылка на который находится в значении
            // свойства PriceChangeHandler, а метод ожидает один входной параметр - price.
            // То есть, из метода Main(), мы передаём ссылку на метод ShowPrice()
            // через свойство PriceChangeHandler, а метод ShowPrice()
            // вызывается из StockExchangeMonitor через свойство PriceChangeHandler.
        }

        // метод который будет выводить текущую цену на консоль
        public static void ShowPrice(int price)
        {
            Console.WriteLine(price);
        }
    }
}
