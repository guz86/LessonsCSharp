using System;

namespace integrationNull
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            string result;

            if (str == null)
            {
                result = "нет данных";
            }
            else
            {
                result = str;
            }
            Console.WriteLine(result);
        }
    }
}
