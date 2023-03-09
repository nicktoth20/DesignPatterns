using DesignPatterns.Creation.Builder;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Creation.Builder;

public class BuilderTests
{
    [Fact]
    public void Should_build_Mini()
    {
        var miniBuilder = new MiniBuilder();
        var garage = new Garage();
        garage.Build(miniBuilder);
        garage.Show().Should().Be("Car of type Mini has part 'not a V8.Car of type Mini has part 3 doors with a stripe.");
    }
    
    [Fact]
    public void Should_build_BMW()
    {
        var bmwBuilder = new BMWBuilder();
        var garage = new Garage();
        garage.Build(bmwBuilder);
        garage.Show().Should().Be("Car of type BMW has part 'a fancy V8 engine.Car of type BMW has part 5-door with metallic finish.");
    }
}