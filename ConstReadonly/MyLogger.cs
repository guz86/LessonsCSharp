using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstReadonly
{
    class MyLogger
    {
        public void Info (string message)
        {
            Console.WriteLine($"{DateTime.Now}\t|INFO|\t{message}");
        }

        public void Error(string message)
        {
            Console.WriteLine($"{DateTime.Now}\t|ERRR|\t{message}");
        }

        public void Warning(string message)
        {
            Console.WriteLine($"{DateTime.Now}\t|WARN|\t{message}");
        }
    }
}
