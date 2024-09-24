using BenchmarkDotNet.Attributes;

namespace Benches;

[MemoryDiagnoser]
[ShortRunJob]
public class WhenDoingCases
{
    private string _string1 = "LucYoaeUDKMl";
    private string _string2 = "lucyoaeudkml";

    [Benchmark]
    public void ToLower()
    {
       if(_string2 == _string1.ToLower() )
       {
        // do something
       }
    }

   [Benchmark]
    public void ToUpper()
    {
       if(_string2 == _string1.ToUpper() )
       {
        // do something
       }
    }


   [Benchmark]
    public void IgnoreCase()
    {
       if(_string2.Equals( _string1, StringComparison.OrdinalIgnoreCase) )
       {
        // do something
       }
    }
}
