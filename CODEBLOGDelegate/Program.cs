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



        static void Main(string[] args)
        {
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

            // предикат, возвращает будево занчение и принимает один аргумент
            Predicate<int> predicate;

            //  в любом случае возвращает какое-то значение
            Func<int> func; // int аргументы до 16шт
            Func<int, string> func2; // string тип возвращаемого значения

            // перед тем как обращаться к делегату нужно проверить на null

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
