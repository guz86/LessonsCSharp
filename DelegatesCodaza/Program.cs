using System;

namespace DelegatesCodaza
{
    class Program
    {
        public delegate void MyDelegate();

        static void Main(string[] args)
        {
            // MyDelegate myDelegate = new(ShowMessage);
            MyDelegate myDelegate = ShowMessage;
            myDelegate();

        }
        
        private static void ShowMessage() {
            Console.WriteLine("Message");
        }
    }
}
