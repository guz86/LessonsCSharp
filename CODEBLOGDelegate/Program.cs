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
            myDelegate();

        }

        public static void Action1()
        {
            Console.WriteLine("Action1");
        }
    }
}
