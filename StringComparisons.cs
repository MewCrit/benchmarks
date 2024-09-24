using BenchmarkDotNet.Attributes;

namespace Benches;

[MemoryDiagnoser]
[ShortRunJob]
public class StringComparisonBenchmark
{
    private string _string1 = "Lucy";
    private string _string2 = "Lucy";

    [Benchmark]
    public void Equal_Sign()
    {
        if (_string1 == _string2)
        {
            // do something
        }
    }

    [Benchmark]
    public void Equal()
    {
        if (_string1.Equals(_string2))
        {
            // do something
        }
    }

    [Benchmark]
    public void Ordinal()
    {
        if (_string1.Equals(_string2, StringComparison.Ordinal))
        {
            // do something
        }
    }

    [Benchmark]
    public void Compare()
    {
        if (string.Compare(_string1, _string2) == 0)
        {
            // do something
        }
    }

    [Benchmark]
    public void Compare_OrdinalIgnoreCase()
    {
        if (string.Compare(_string1, _string2, StringComparison.OrdinalIgnoreCase) == 0)
        {
            // do something
        }
    }

    [Benchmark]
    public void CompareTo()
    {
        if (_string1.CompareTo(_string2) == 0)
        {
            // do something
        }
    }

    [Benchmark]
    public void InvariantCulture()
    {
        if (_string1.Equals(_string2, StringComparison.InvariantCulture))
        {
            // do something
        }
    }

    [Benchmark]
    public void CurrentCulture()
    {
        if (_string1.Equals(_string2, StringComparison.CurrentCulture))
        {
            // do something
        }
    }
}
