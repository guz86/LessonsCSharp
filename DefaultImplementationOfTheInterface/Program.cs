using System;

namespace DefaultImplementationOfTheInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            // реализация интерфейса по-умолчанию
            ILogger logger = new ConsoleLogger();
            logger.Log(LogLevel.Debug, "some");
            logger.Log(LogLevel.Info, "some info");
            logger.Log(LogLevel.Error, "some error");
        }
    }
}
