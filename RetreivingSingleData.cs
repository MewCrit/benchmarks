using Benches.Data;
using BenchmarkDotNet.Attributes;

namespace Benches;

[MemoryDiagnoser]
[ShortRunJob]
public class RetreivingSingleData
{   

    private List<Product> _products;

    [GlobalSetup]
    public void Setup()
    {   
        var p = new ProductData();
        _products = p.ProductsSamples();
    }

    [Benchmark]
    public void FirstOrDefault()
    {
        _products.FirstOrDefault(x=> x.ID == "P001");
    }

    [Benchmark]
    public void First()
    {
        _products.First(x=> x.ID == "P001");
    }

    [Benchmark]
    public void SingleOrDefault()
    {
        _products.SingleOrDefault(x=> x.ID == "P001");
    }

    [Benchmark]
     public void Single()
    {
        _products.Single(x=> x.ID == "P001");
    }

    [Benchmark]
    public void Find()
    {
        _products.Find(x=> x.ID == "P001");

    }
}


