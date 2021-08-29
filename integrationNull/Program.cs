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
                result = "нет данных в str";
            }
            else
            {
                result = str;
            }
            Console.WriteLine(result);

            // unhandled exception необработанное исключение
            //Console.WriteLine( "количество символов в str " + str.Length);
            // string resultNew = str ?? "";
            string resultNew = str ?? string.Empty;
            Console.WriteLine("количество символов в str " + resultNew.Length);




            // easy
            string strNew = null;
            Console.WriteLine(strNew ?? "нет данных в strNew");




            //
            // оператор присваивания объединения со значением null ??=

            string str2 = null;

            string result2 = str2 ??= "default string";
            Console.WriteLine("количество символов в str " + result2.Length);

        }
    }
}
