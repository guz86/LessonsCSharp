using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using StructureXY;

namespace BenchmarkStructClass

{
    [MemoryDiagnoser]
    [RankColumn]
    public class MyStructClassBanchmark
    {
        [Benchmark]
        public void StructTest()
        {
            StructPoint structPoint = new StructPoint();
            structPoint.X = 1;
            structPoint.Y = 2;
            var result = structPoint.X + structPoint.Y;
        }

        [Benchmark]
        public void ClassTest()
        {
            ClassPoint classPoint = new ClassPoint();
            classPoint.X = 1;
            classPoint.Y = 2;
            var result = classPoint.X + classPoint.Y;
        }

    }
}
