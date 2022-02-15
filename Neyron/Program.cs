using System;

namespace Neyron
{
    class Program
    {
        static void Main(string[] args)
        {
            // километры в мили
            decimal km = 100;
            decimal miles = 62.1371m;

            // при передаче нейрону km он должен их конвертировать в правильное количество миль

            Neuron neuron = new Neuron();
            Console.WriteLine($"{neuron.ProcessingInputData(km)}  миль в {km} километрах");
            // обучим нейрон выдавать правильный результат
            int i = 0;
            do
            {
                i++;
                // обучайся по этому примеру
                neuron.Train(km, miles);
                // выводим информацию о каждой 100000 операции
                if (i % 100000 == 0)
                {
                    Console.WriteLine($"Итерация {i} \t Ошибка \t {neuron.LastError}");

                }
                // сравниваем ошибку со сглаживанием  - больши или меньше сглаживания
            } while (neuron.LastError > neuron.Smoothing || neuron.LastError < -neuron.Smoothing);
            Console.WriteLine("Обучение завершено");



            Console.WriteLine($"{neuron.ProcessingInputData(100)}  миль в {100} километрах");

            Console.WriteLine($"{neuron.ProcessingInputData(540)}  миль в {540} километрах");

            // сколько километров в 10 милях

            Console.WriteLine($"{neuron.RestoreInputData(10)}  км в {10} милях");

        }
    }
}
