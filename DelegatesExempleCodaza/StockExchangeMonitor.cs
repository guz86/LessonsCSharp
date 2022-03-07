using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegatesExempleCodaza
{
    public class StockExchangeMonitor
    {
        public delegate void PriceChange(int price);
        //price текущая цена на акцию

        // добавим свойство через которое можно будет зарегистрировать ссылку на метод
        // через этот код внешний код сможет добавять методы для оповещения о новой цене
        public PriceChange PriceChangeHandler { get; set; }
        // метод чтобы запустить наш монитор
        public void Start() {
            // опрос биржи
            while (true)
            {
                // получаем текущую цену
                int bankOfAmericaPrice = (new Random()).Next(100);
                // оповестим всех желающих о новой цене
                PriceChangeHandler(bankOfAmericaPrice);

                Thread.Sleep(1500);
            }
        }
    }
}
