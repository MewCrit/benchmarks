using AutoMapper;
using BenchmarkDotNet.Attributes;
using Mapster;

namespace Benches;

[MemoryDiagnoser]
[ShortRunJob]
public class Mapping
{
    private Cat? _cat;
   
    [GlobalSetup]
    public void Setup()
    {   
        _cat = new Cat
        {
            Name = "Namaste",
            Breed = "British Shortail"
        };
    }

    [Benchmark]
    public void ManualMapping()
    {
        var catDto = new CatDto
        {
            Name = _cat.Name,
            Breed = _cat.Breed
        };

    }

    [Benchmark]
    public void AutoMapper()
    {
        var configuration = new MapperConfiguration(cfg => 
        {
            cfg.CreateMap<Cat, CatDto>(); 
        });

        configuration.AssertConfigurationIsValid();
        var mapper = configuration.CreateMapper();
        var fooDto = mapper.Map<CatDto>(_cat);

    }

    [Benchmark]
    public void Mapster()
    {
        TypeAdapterConfig<Cat, CatDto>.NewConfig();

        var catDto = _cat.Adapt<CatDto>();
    }
   
}



class Cat
{
    public string? Name { get; set; }

    public string? Breed { get; set; }
}


class CatDto
{
    public string? Name { get; set; }

    public string? Breed { get; set; }
}