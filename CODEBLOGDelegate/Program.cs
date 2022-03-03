using System;

namespace DelegateCODEBLOG
{
    // Указатель на метод. Сигнатура делегата опеределяем методы с какой сигнатурой в нем будут использаться
    //
    public delegate void MyDelegate();
    // не принимает аргументов, не возвращает значений
    class Program
    {
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
        }

        public static void Action1()
        {
            Console.WriteLine("Action1");
        }
        public static void Action2()
        {
            Console.WriteLine("Action2");
        }
    }
}
