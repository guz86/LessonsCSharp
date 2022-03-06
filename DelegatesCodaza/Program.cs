using System;

namespace DelegatesCodaza
{
    class Program
    {
        public delegate void MyDelegate();
        //
        public delegate string MyDelegateParam(string name);

        static void Main(string[] args)
        {
            // MyDelegate myDelegate = new(ShowMessage);
            MyDelegate myDelegate = ShowMessage;
            myDelegate();

            // с параметрами
            MyDelegateParam myDelegateParam = ShowName;
            Console.WriteLine(myDelegateParam("Alexey"));

        }
        
        private static void ShowMessage() {
            Console.WriteLine("Message");
        }
        //
        private static string ShowName(string name)
        {
            return $"Hi, {name}";
        }
    }
}
