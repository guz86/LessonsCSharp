using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultImplementationOfTheInterface
{
    public interface ILogger
    {
        void Log(LogLevel logLevel, string message);
        // методы которым не требуется хранить состояние
        void Foo()
        {
            Console.WriteLine("Foo");
        }
        void Sum(int a, int b)
        {
            Console.WriteLine(a+b);
        }  
    }

}
