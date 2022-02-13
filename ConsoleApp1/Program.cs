using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Myproj;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = MyLibrory.Add(1, 3);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
