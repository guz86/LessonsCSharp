using System;

namespace MultiplicationTables
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodsInputArrayAndNestedLoops();

        }


        public static void MethodsInputArrayAndNestedLoops()
        {
            
            // ввод данных
            int inputUserMethod = Init();
            // создание и заполнение таблицы
            int [,] myArrayMethod = CalcTable(inputUserMethod);
            // вывод таблицы на экран
            OutputTable(inputUserMethod, myArrayMethod);

        }
        public static int Init()
        {
            Console.WriteLine("Введите значение:");
            bool check = int.TryParse(Console.ReadLine(), out int inputUser);
            if (!check)
            {
                Console.WriteLine("Ввели не цифру");
            } 
            return inputUser;
        }

        public static int[,] CalcTable(int inputUser)
        {
            int[,] myArray = new int[inputUser, inputUser];
            // пробегаемся по элементам массива и проставляем значения на основе i j
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = (i + 1) * (j + 1);
                }
                
            }
            return myArray;
        }
        public static void OutputTable(int inputUser, int[,] myArray)
        {
            // вывод
            for (int i = 0; i < inputUser; i++)
            {
                Console.Write($"\t{i + 1}");
            }
            Console.WriteLine();
            for (int i = 0; i < inputUser; i++)
            {

                Console.Write($"{i + 1}");
                for (int j = 0; j < inputUser; j++)
                {
                    Console.Write($"\t{ myArray[j, i]}");
                }
                Console.WriteLine();
            }

        }


        static public void WithoutArrays()
        {
            // таблица умножения 2 на 2 без массивов
            int x1_1, x1_2;
            int x2_1, x2_2;

            x1_1 = 1 * 1; x1_2 = 1 * 2;
            x2_1 = 2 * 1; x2_2 = 2 * 2;

            Console.WriteLine("\t1 \t2");
            Console.WriteLine($"1\t{x1_1}\t{x1_2}");
            Console.WriteLine($"2\t{x2_1}\t{x2_2}");
            
        }

        static public void SimpleArray()
        {
            // глупое использование массива

            int [,] myArray = new int[2, 2];
            myArray[0,0] = 1 * 1; myArray[0,1] = 1 * 2;
            myArray[1, 0] = 1 * 2; myArray[1, 1] = 2 * 2;



            Console.WriteLine("\t1 \t2");
            Console.WriteLine($"1\t{myArray[0, 0]}\t{myArray[0, 1]}");
            Console.WriteLine($"2\t{myArray[1, 0]}\t{myArray[1, 1]}");
        }
        static public void ArrayAndCycles()
        {
            // поочереди заполняем массив
            int[,] myArray = new int[2, 2];

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                myArray[0, i] = (i + 1) * 1;
            }
            for (int i = 0; i < myArray.GetLength(1); i++)
            {
                myArray[1, i] = (i + 1) * 2;
            }

           // расширяемый вывод
            for (int i = 0; i < 2; i++)
            {
                // Console.Write("\t"+(i+1));
                Console.Write($"\t{i+1}");
            }
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"{i + 1}\t{myArray[i, 0]}\t{myArray[i, 1]}");
            }


        }

        public static void ArrayAndNestedLoops()
        {
            int[,] myArray = new int[2, 2];
            // пробегаемся по элементам массива и проставляем значения на основе i j
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j   = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = (i + 1) * (j + 1);
                }
            }

            // вывод
            for (int i = 0; i < 2; i++)
            {
                // Console.Write("\t"+(i+1));
                Console.Write($"\t{i + 1}");
            }
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                //Console.WriteLine($"{i + 1}\t{myArray[i, 0]}\t{myArray[i, 1]}");

                Console.Write($"{i + 1}");
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"\t{ myArray[j, i]}");
                }
                Console.WriteLine();
            }

        }

        public static void InputArrayAndNestedLoops()
        {
            
            Console.WriteLine("Введите значение:");
            bool check = int.TryParse(Console.ReadLine(), out int inputUser);
            if (!check)
            {
                Console.WriteLine("Ввели не цифру");
            }
            int[,] myArray = new int[inputUser, inputUser];
            // пробегаемся по элементам массива и проставляем значения на основе i j
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = (i + 1) * (j + 1);
                }
            }
            
            // вывод
            for (int i = 0; i < inputUser; i++)
            {
                // Console.Write("\t"+(i+1));
                Console.Write($"\t{i + 1}");
            }
            Console.WriteLine();
            for (int i = 0; i < inputUser; i++)
            {
                //Console.WriteLine($"{i + 1}\t{myArray[i, 0]}\t{myArray[i, 1]}");

                Console.Write($"{i + 1}");
                for (int j = 0; j < inputUser; j++)
                {
                    Console.Write($"\t{ myArray[j, i]}");
                }
                Console.WriteLine();
            }

        }

        




    }
}
