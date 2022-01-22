using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchTest;


namespace Benchmark
{
    class MyParserBenchmark
    {
        private const string STRING_TO_PARSE_WITH_ERROR = "sdfsdf3";
        private const string STRING_TO_PARSE = "44";

        
        private MyParser myParser = new MyParser();

        [Benchmark]
        public void TryCatchParseTestWithError()
        {
            int result = myParser.TryCathParse(STRING_TO_PARSE_WITH_ERROR);

        }
        [Benchmark]
        public void TryParseTestWithError()
        {
            int result = myParser.TryParse(STRING_TO_PARSE_WITH_ERROR);

        }
    }
}
