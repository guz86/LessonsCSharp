using System;
using BenchmarkDotNet.Running;

namespace BenchmarkStructClass
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<MyStructClassBanchmark>();
        }
    }
}
