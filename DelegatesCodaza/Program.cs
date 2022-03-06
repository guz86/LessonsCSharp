﻿using System;

namespace DelegatesCodaza
{
    class Program
    {
        public delegate void MyDelegate();
        //
        public delegate string MyDelegateParam(string name);
        //

        public delegate void DelegateMulti();

        static void Main(string[] args)
        {

            // SingeCast делегаты - ссылаются на 1 метод

            // MyDelegate myDelegate = new(ShowMessage);
            MyDelegate myDelegate = ShowMessage;
            myDelegate();

            // с параметрами
            MyDelegateParam myDelegateParam = ShowName;
            Console.WriteLine(myDelegateParam("Alexey"));

            // если методов несколько то это Multicast делегаты
            DelegateMulti delegateMulti = Func1;
            delegateMulti += Func2;
            delegateMulti();
        }
        
        private static void ShowMessage() {
            Console.WriteLine("Message");
        }
        //
        private static string ShowName(string name)
        {
            return $"Hi, {name}";
        }

        private static void Func2()
        {
            Console.WriteLine("Func2");
        }
        private static void Func1()
        {
            Console.WriteLine("Func1");
        }
    }
}
