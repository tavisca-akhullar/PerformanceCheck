using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Running;

namespace PerformanceCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            var check = BenchmarkRunner.Run<StructVsClass>();
            Console.Read();
        }
  }
}

  
