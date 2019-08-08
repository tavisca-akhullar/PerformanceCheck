``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.1 (1803/April2018Update/Redstone4)
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
Frequency=2742189 Hz, Resolution=364.6722 ns, Timer=TSC
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3056.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3056.0


```
| Method | value |     Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------- |------ |---------:|----------:|----------:|-------:|------:|------:|----------:|
| Struct |    10 | 1.164 us | 0.0141 us | 0.0132 us | 0.2460 |     - |     - |     520 B |
|  Class |    10 | 1.208 us | 0.0114 us | 0.0106 us | 0.3033 |     - |     - |     640 B |
