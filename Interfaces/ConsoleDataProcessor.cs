using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class ConsoleDataProcessor : IDataProcessor
    {
        public void ProcessorData(IDataProvider dataProvider)
        {
            Console.WriteLine(dataProvider.GetData());
        }
    }
}
