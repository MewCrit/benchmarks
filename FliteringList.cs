

using Benches.Data;
using BenchmarkDotNet.Attributes;


[MemoryDiagnoser]
[ShortRunJob]
public class FliteringList
{

    private List<Product> _products;

    [GlobalSetup]
    public void Setup()
    {   
        var p = new ProductData();
        _products = p.ProductsSamples();
    }

    [Benchmark]
    public void WhereClause()
    {
        _products.Where(x => x.ItemName == "Smartphone");
    }

    [Benchmark]
    public void WhereClauseEqual()
    {
        _products.Where(x => x.ItemName.Equals("Smartphone", StringComparison.Ordinal));
    }

    [Benchmark]
    public void Manual()
    {   
        foreach(var product in _products)
        {
            if(product.ItemName == "Smartphone")
            {
                // do something
            }

        }
    }


}