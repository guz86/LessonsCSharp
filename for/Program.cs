using System;

namespace forI
{
    class Program
{
    static void Main(string[] args)
    {
            /*
        int i = 0;
        for (; i < 5; i++)
        {
            Console.WriteLine("for1 " + i);
        }
        for (; i < 10; i++)
        {
            Console.WriteLine("for2 " + i);
        }
            */

            // несколько преременных, несколько условий, порядок внутри цикла

            for (int i = 0, j = 2; i < 5 && j < 5; j++)
            {
                i++;
                Console.WriteLine("before " + i);

                Console.WriteLine("j " + j);
            }
            for (int i = 0; i < 5; )
            {
                Console.WriteLine("after " + i);
                i++;
            }
            // прямой обратный порядок
            // for (int i = 0, j = 5; i <= 5 && j >= 0 ; i++, j--)
            for (int i = 0, j = 5; i <= 5; i++, j--)
            {
                Console.WriteLine("i "+ i);
                Console.WriteLine("j "+ j);
            }

        }
    }
}
