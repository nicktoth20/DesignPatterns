using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Structural.Composite;

public class CompositeTests
{
    [Fact]
    public void Should_get_sizes()
    {
        var root = new DesignPatterns.Structural.Composite.Directory("root", 0);
        var topLevelDirectory1 = new DesignPatterns.Structural.Composite.Directory("root", 4);
        var topLevelDirectory2 = new DesignPatterns.Structural.Composite.Directory("root", 4);
        var topLevelFile = new DesignPatterns.Structural.Composite.File("toplevel.txt", 100);
        root.Add(topLevelDirectory1);
        root.Add(topLevelDirectory2);
        root.Add(topLevelFile);
        var subLevelFile1 = new DesignPatterns.Structural.Composite.File("sublevel1.txt", 200);
        var subLevelFile2 = new DesignPatterns.Structural.Composite.File("sublevel2.txt", 150);        
        topLevelDirectory2.Add(subLevelFile1);
        topLevelDirectory2.Add(subLevelFile2);

        root.GetSize().Should().Be(458);
        topLevelDirectory1.GetSize().Should().Be(4);
        topLevelDirectory2.GetSize().Should().Be(354);
    }
}