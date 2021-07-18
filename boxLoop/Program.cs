using System;

namespace boxLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 10; // Convert.ToInt32(Console.ReadLine());
            int width = 10; // Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < height; i++)
            {

                
                for (int j = 0; j < width; j++)
                {
                   
                        Console.Write("[]");
                    

                }

                Console.WriteLine();
            }

            Console.WriteLine(); 


            int heightTriangle = 10; // Convert.ToInt32(Console.ReadLine());
            //int widthTriangle = 20; // Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < heightTriangle; i++)
            {

               

                for (int j = heightTriangle; j > i; j--)
                {
                    Console.Write("*");
                }


                Console.WriteLine();
            }

            Console.WriteLine();


            int heightTriangle2 = 10; // Convert.ToInt32(Console.ReadLine());
            //int widthTriangle = 20; // Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < heightTriangle2; i++)
            {



                for (int j = 0; j <= i; j++)
                {
                    Console.Write("%");
                }


                Console.WriteLine();
            }

            Console.WriteLine();




            int heightTriangle5 = 10;

            for (int i = 0; i < heightTriangle5; i++)
            {
                for (int j = heightTriangle5; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("=");
                }

                Console.WriteLine();

            }

        }
    }
}

