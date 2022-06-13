using BenchmarkDotNet.Attributes;

namespace PerformanceEnums
{
    [MemoryDiagnoser(false)]
    public class Benchmarks
    {
        [Benchmark]
        public string EnumToString()=> Color.LightGreen.ToString();
        
        [Benchmark]
        public string EnumToStringFast() => Color.LightGreen.ToStringFast();

        [Benchmark]
        public bool EnumIsDefined() => Enum.IsDefined(typeof(Color), (Color)69);

        [Benchmark]
        public bool EnumIsDefinedFast() => ColorExtensions.IsDefined((Color)69);

        [Benchmark]
        public (bool, Color) EnumTryParse()
        {
            var couldParse = Enum.TryParse("LightGreen",false, out Color value);
                return (couldParse, value);
        }

        [Benchmark]
        public (bool, Color) EnumTryParseFast()
        {
            var couldParse = ColorExtensions.TryParse("LightGreen", false, out Color value);
            return (couldParse, value);
        }
    }
}
