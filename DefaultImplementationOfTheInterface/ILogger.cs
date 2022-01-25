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
        // добавление метода, чтобы не реализовывать его в каждом классе
        // можно задать значение по умолчанию
        void LogError(string message)
        {
            Log(LogLevel.Error, message);
        }
    }

}
