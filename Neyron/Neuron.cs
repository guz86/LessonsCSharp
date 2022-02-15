using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neyron
{
    public class Neuron
    {
        private decimal weight = 0.5m;
        public decimal LastError { get; private set; }

        // добавим сглаживание, чтобы шаг коррекции не было очень большим
        // чем больше, тем хуже точность, но выше скорость обучения
        public decimal Smoothing { get; set; } = 0.000001m;

        // метод который будет получать входящий сигнал извне и будет его обрабатывать
        public decimal ProcessingInputData(decimal input)
        {
            return input * weight;
        }

        // инвертировать действие
        public decimal RestoreInputData(decimal input)
        {
            return input / weight;
        }

        // метод который будет обучать наш нейрон
        // нужно показать пример как должно быть
        public void Train(decimal input, decimal expectedResult)
        {
            // как должно быть
            var ActualResult = weight * input;
            // вычисляем ошибку
            LastError =  expectedResult - ActualResult;
            // вычислим значение на которое нам нужно скорректировать
            // в weght чтобы эту ошибку исправить
            //var correction = LastError / ActualResult;
            var correction = (LastError / ActualResult) * Smoothing;
            // прибавляем его к весу
            weight += correction;
        }
    }
    
}
