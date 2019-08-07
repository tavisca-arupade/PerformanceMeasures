``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.885 (1803/April2018Update/Redstone4)
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
Frequency=2742183 Hz, Resolution=364.6730 ns, Timer=TSC
.NET Core SDK=2.2.401
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
|    Method |      Mean |    Error |   StdDev | Rank |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |----------:|---------:|---------:|-----:|-------:|------:|------:|----------:|
| TestArray |  93.63 ns | 1.900 ns | 3.328 ns |    1 | 0.2021 |     - |     - |     424 B |
|  TestList | 398.79 ns | 5.638 ns | 5.274 ns |    2 | 0.5679 |     - |     - |    1192 B |
