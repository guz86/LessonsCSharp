using System;

namespace DefaultImplementationOfTheInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.Log(LogLevel.Debug, "some");
            logger.Log(LogLevel.Info, "some info");
            logger.Log(LogLevel.Error, "some error");

            // реализация интерфейса по-умолчанию
            logger.Foo();
            logger.Sum(1, 2);

        }
    }
}
