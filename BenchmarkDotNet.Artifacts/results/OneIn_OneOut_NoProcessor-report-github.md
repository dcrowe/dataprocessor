``` ini

BenchmarkDotNet=v0.10.13, OS=macOS 10.13.4 (17E202) [Darwin 17.5.0]
Intel Core i7-4558U CPU 2.80GHz (Haswell), 1 CPU, 4 logical cores and 2 physical cores
  [Host]     : Mono 5.10.1.47 (2017-12/8eb8f7d5e74 Fri), 64bit 
  DefaultJob : Mono 5.10.1.47 (2017-12/8eb8f7d5e74 Fri), 64bit 


```
|  Method | RunLength |         Mean |        Error |       StdDev |       Median | Scaled | ScaledSD |  Gen 0 | Allocated |
|-------- |---------- |-------------:|-------------:|-------------:|-------------:|-------:|---------:|-------:|----------:|
| Optimal |       100 |     529.8 ns |     8.479 ns |     7.080 ns |     529.4 ns |   1.00 |     0.00 |      - |       0 B |
|   Naive |       100 | 245,196.9 ns | 4,806.730 ns | 6,416.847 ns | 245,828.4 ns | 462.86 |    13.28 | 3.4180 |       0 B |
|  Actual |       100 |     582.9 ns |    12.684 ns |    36.188 ns |     567.4 ns |   1.10 |     0.07 |      - |       0 B |
