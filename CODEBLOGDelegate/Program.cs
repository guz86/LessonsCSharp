using System;

namespace DelegateCODEBLOG
{
    // Указатель на метод. Сигнатура делегата опеределяем методы с какой сигнатурой в нем будут использаться
    //
    public delegate void MyDelegate();
    // не принимает аргументов, не возвращает значений


    class Program
    {
        // делегат внутри класса
        public delegate int ValueDelegate(int i);


        // СОБЫТИЯ
        // событие объявляется в классе с помощью делегата

        // выше public delegate void MyDelegate();
        public event MyDelegate Event;
       // или
        public event Action EventAction;

        static void Main(string[] args)
        {
            #region delegate
            MyDelegate myDelegate = Action1;
            // второй метод в переменную делегата
            myDelegate += Action2;
            myDelegate();

            Console.WriteLine();
            // создать делегат и добавить в него метод
            MyDelegate myDelegate2 = new MyDelegate(Action2);
            myDelegate2.Invoke();
            Console.WriteLine();


            // в один делегат можно добавить один и тот же метод несколько раз
            myDelegate2 += Action2;
            myDelegate2 += Action2;
            // удалить

            myDelegate2 -= Action2;

            myDelegate2.Invoke();

            Console.WriteLine();

            // соединение делегатов

            MyDelegate myDelegate1 = myDelegate + myDelegate2;
            myDelegate1();


            //
            ValueDelegate valueDelegate = new ValueDelegate(ActionValue);
            valueDelegate += ActionValue;
            valueDelegate += ActionValue;
            valueDelegate(5);
            // 5 будет передана во все методы делегата

            valueDelegate((new Random()).Next(9, 99));

            // шаблон делегата


            // шаблонные делегаты, зданный не нужно создавать, сразу использовать, может быть перегружен от 0 до 16 аргументов
            // можно не объявлять public delegate void Action() - делегат который не возвращает значения;
            Action ActionDelegate = Action1;
            ActionDelegate();
            // с аргументом принимает от 0 до 16 аргументов
            // можно не объявлять public delegate void Action(int i) 
            Action<int> ActionDelegateInt = ActionValue2;
            ActionDelegateInt(4);

            // предикат, возвращает булево значение и принимает один аргумент
            // можно не объявлять public delegate bool Predicate<T>(T value)
            // можно не объявлять public delegate bool Predicate(int i)
            Predicate<int> predicate;

            //  в любом случае возвращает какое-то значение
            // можно не объявлять public delegate int Func()
            Func<int> func; // int возвращает и аргументы до 16шт

            // можно не объявлять public delegate int Func(string s)
            Func<int, string> func2; // string тип возвращаемого значения

            // ОБЯЗАТЕЛЬНО перед тем как обращаться к делегату нужно проверить на null
            Func<int,int> func3 = ActionValue;
            if (func3 != null) // есть ли в нем какие то методы
            func3(333);
            // или присутствует ли внутри делегата хотя бы один метод, если нет ничего не произойдет и выполнение скрипта пойдет дальше
            func3?.Invoke(6666);
            Console.WriteLine();
            #endregion


            // СОБЫТИЯ

            // пример, человек спит
            Person person = new()
            {
                Name = "Alexey"
            };
            // подписываемся на событие
            person.GoToSleep += Person_GoToSleep;

            person.DoWork += Person_DoWork;

            person.TakeTime(DateTime.Parse("04.03.2022 14:33:00"));
            person.TakeTime(DateTime.Parse("04.03.2022 03:33:00"));


            // чаще используется шаблон делегата EventHandler
        }

        private static void Person_DoWork(object sender, EventArgs e)
        {
            if (sender is Person)
            {
                Console.WriteLine($"{((Person)sender).Name} пошел работать");

            }
        }

        //обработчик события начало
        private static void Person_GoToSleep()
        {
            Console.WriteLine("Пошел спать");
        }

        //обработчик события конец




        public static void Action1()
        {
            Console.WriteLine("Action1");
        }
        public static void Action2()
        {
            Console.WriteLine("Action2");
        }

        public static int ActionValue(int i)
        {
            Console.WriteLine(i);
            return i;
        }

        public static void ActionValue2(int i)
        {
            Console.WriteLine(i);
            
        }
    }
}
