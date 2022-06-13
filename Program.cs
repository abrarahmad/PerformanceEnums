using BenchmarkDotNet.Running;
using PerformanceEnums;


//https://github.com/andrewlock/NetEscapades.EnumGenerators

BenchmarkRunner.Run<Benchmarks>();

//var color = Color.LightGreen;
//Console.WriteLine(color.ToString());
//var matched = Enum.TryParse("LightGreen", out Color theColor);

//var isDefined = Enum.IsDefined(typeof(Color), (Color)69);