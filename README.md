# dataprocessor
A library for dynamically constructing processing graphs in C#

[![Build status](https://ci.appveyor.com/api/projects/status/ypnihkeuuf3pom7l?svg=true)](https://ci.appveyor.com/project/dcrowe/dataprocessor)
[![codecov](https://codecov.io/gh/dcrowe/dataprocessor/branch/master/graph/badge.svg)](https://codecov.io/gh/dcrowe/dataprocessor)

dataprocessor makes it easy to construct data processors at run-time in .Net. It's easy enough to hook functions to together at compile time, but when you have an unknown number of parameters and algorithms created at run-time, you may want some help.

```C#
var builder = new DataProcessorBuilder();

var writer = builder.AddInput<int>("input");
builder.AddProcessor<int, int>("input", "output", input => output + 1);
builder.AddListener<int>("output", output => Console.Out.WriteLine(output));

var processor = builder.Build();

writer.Send(42);
```
