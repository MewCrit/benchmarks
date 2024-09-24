using BenchmarkDotNet.Attributes;

namespace Benches;

[MemoryDiagnoser]
[ShortRunJob]
public class AddToListBenchmarks
{
    private int[] _numbersArray = Enumerable.Range(1, 100).ToArray();


      [Benchmark]
     public void Add_Single_Item()
     {
        var numbers = new List<int>();
        for (int i = 0; i < 100; i++)
        {
            numbers.Add(i);
        }
     }
    
     [Benchmark]
     public void Add_Range()
     {  
        var num = new List<int>();
        num.AddRange(_numbersArray);
     }

    [Benchmark]
    public void Insert_Single_Item()
    {
        List<int> numbers = new List<int>();
        for (int i = 0; i < 100; i++)
        {
            numbers.Insert(0, i); 
        }
    }

     [Benchmark]
     public void Insert_Range()
     {
            List<int> number = new List<int>();
            number.InsertRange(0, _numbersArray);
     }





}