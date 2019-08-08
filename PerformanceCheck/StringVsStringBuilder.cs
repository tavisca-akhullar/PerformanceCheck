using System;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace PerformanceCheck
{
    [MemoryDiagnoser]
   public class StringVsStringBuilder
    {
        [Params(10)]
       public int value=10;

        [Benchmark]
        public void String()
        {

            for (int i = 0; i < value; i++)
            {
                string name = "Aman" + i;
                Console.WriteLine($"The String value is{name}");
            }
        }



        [Benchmark]
        public void StringBuilder()
        {

            for (int i = 0; i < value; i++)
            {
                StringBuilder name = new StringBuilder("Aman"+i); 
                Console.WriteLine($"The String value is{name}");
            }
        }
    }
}

  
