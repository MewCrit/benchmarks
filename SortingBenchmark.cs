using Benches.Data;
using BenchmarkDotNet.Attributes;

namespace Benches;

[MemoryDiagnoser]
[ShortRunJob]
public class SortingBenchmark
{   

    private List<Product> _products;

    [GlobalSetup]
    public void Setup()
    {   
        var p = new ProductData();
        _products = p.ProductsSamples();
    }

    [Benchmark]
    public void Sort_By_Sort()
    {
        _products.Sort((p1, p2) => string.Compare(p1.ItemName, p2.ItemName));
    }

    [Benchmark]
    public void Sort_By_OrderBy()
    {
        _products.OrderBy(x => x.ItemName);
    }


    [Benchmark]
    public void Sort_By_OrderByDescending()
    {
        _products.OrderByDescending(x => x.ItemName);
    }

    [Benchmark]
    public void Sort_By_BubbleSort()
    {
          var n = _products.Count;
          for (var i = 0; i < n - 1; i++)
            {
            for (var j = 0; j < n - i - 1; j++)
            {
                if (string.Compare(_products[j].ItemName, _products[j + 1].ItemName, StringComparison.Ordinal) > 0)
                {
                    Product temp = _products[j];
                    _products[j] = _products[j + 1];
                    _products[j + 1] = temp;
                }
            }
         }
    }



}


