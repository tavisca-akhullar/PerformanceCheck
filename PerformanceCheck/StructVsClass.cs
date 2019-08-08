using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace PerformanceCheck
{
    [MemoryDiagnoser]
  public   class StructVsClass
    {
        [Params(10)]
       public int value = 10;


        [Benchmark]
        public void Struct()
        {
            for (int i = 0; i < value; i++)
            {
                Employee employee = new Employee("Aman"+i);
            }
        }


        [Benchmark]
        public void Class()
        {
            for (int i = 0; i < value; i++)
            {
                Student student = new Student("Aman"+i);
            }
        }
    }
}

  
