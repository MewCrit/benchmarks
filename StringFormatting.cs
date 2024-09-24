using System.Text;
using BenchmarkDotNet.Attributes;

namespace Benches;

[MemoryDiagnoser]
[ShortRunJob]
public class StringFormatting
{
    private string _string1 = "Is called internal pointer varialble";
    private string _string2 = "What is this internal pointer varialble. When you use this syntax, you are telling the variable to store the memory address of the first array element of arr (arr[0]). We call this memory address the internal pointer variable. All composite data types (e.g., arrays, structures, etc...) have its own internal pointer, and it is always the memory address of its first element.";
    StringBuilder sb = new StringBuilder();

    [Benchmark]
    public void Concatenate()
    {
      var what = _string1 + " " + _string2;
    }

   [Benchmark]
    public void StringFormat()
    {
       var what = string.Format("{0} {1}", _string1, _string2);
    }


    [Benchmark]
    public void StringInterpolation()
    {
       var what =  $"{_string1} {_string2}";  
    }

    [Benchmark]
    public void StringJoin()
    {
        var what =  string.Join(_string2, _string2);
    }

    [Benchmark]
    public void StringBuilder()
    {
        sb.Append(_string1);
        sb.Append(_string2);
        sb.ToString();
    }


}
