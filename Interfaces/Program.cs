using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataProcessor dataProcessor = new ConsoleDataProcessor();
            dataProcessor.ProcessorData(new ApiDataProvider());
            dataProcessor.ProcessorData(new DbDataProvider());
            dataProcessor.ProcessorData(new FileDataProvider());


        }
    }
}
