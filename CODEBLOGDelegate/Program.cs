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


        // событие объявляется в классе с помощью делегата

        public event MyDelegate Event;
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



            // шаблонные делегаты, зданный не нужно создавать, сразу использовать, может быть перегружен от 0 до 16 аргументов
            Action ActionDelegate = Action1;
            ActionDelegate();

            Action<int> ActionDelegateInt = ActionValue2;
            ActionDelegateInt(4);

            // предикат, возвращает булево значение и принимает один аргумент
            Predicate<int> predicate;

            //  в любом случае возвращает какое-то значение
            Func<int> func; // int аргументы до 16шт
            Func<int, string> func2; // string тип возвращаемого значения

            // перед тем как обращаться к делегату нужно проверить на null
            Func<int,int> func3 = ActionValue;
            if (func3 != null)
            func3(333);

            // или присутствует ли внутри делегата хотя бы один метод, если нет ничего не произойдет и выполнение скрипта пойдет дальше
            func3?.Invoke(6666);
            #endregion
            Console.WriteLine();
            // человек спит
            Person person = new Person();
            // подписываемся на событие
            person.GoToSleep += Person_GoToSleep;

            person.TakeTime(DateTime.Parse("04.03.2022 14:33:00"));
            person.TakeTime(DateTime.Parse("04.03.2022 03:33:00"));
        }

        //обработчик события
        private static void Person_GoToSleep()
        {
            Console.WriteLine("Пошел спать");
        }

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
