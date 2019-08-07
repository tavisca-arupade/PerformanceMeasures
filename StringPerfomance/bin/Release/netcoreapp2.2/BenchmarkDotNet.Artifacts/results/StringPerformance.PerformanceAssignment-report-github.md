``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.885 (1803/April2018Update/Redstone4)
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
Frequency=2742183 Hz, Resolution=364.6730 ns, Timer=TSC
.NET Core SDK=2.2.401
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
|            Method |     Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------ |---------:|----------:|----------:|-------:|------:|------:|----------:|
|        TestString | 16.63 ns | 0.3684 ns | 0.5844 ns | 0.0229 |     - |     - |      48 B |
| TestStringBuilder | 26.59 ns | 0.5866 ns | 0.5487 ns | 0.0496 |     - |     - |     104 B |
