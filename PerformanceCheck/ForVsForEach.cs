using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace PerformanceCheck
{
    [MemoryDiagnoser]
public class ForVsForEach
{
    [Params(100)]
    public int value;

    int[] values;
    public ForVsForEach()
    {
        values = new int[value];
        for (int i = 0; i < value; i++)
        {
            values[i] = i;
        }
    }



    [Benchmark]
    public void For()
    {

        for (int i = 0; i < values.Length; i++)
        {
            Console.WriteLine($"Hiii..The value in for loop iterator   {values[i]}");
        }
    }



    [Benchmark]
    public void ForEach()
    {

        foreach (var value in values)
        {
            Console.WriteLine($"Hiii..The value in foreach loop  is  {value}");
        }
    }
}
}

  
