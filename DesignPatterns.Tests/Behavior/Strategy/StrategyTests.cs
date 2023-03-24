using AutoBogus;
using DesignPatterns.Behavior.Strategy;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Behavior.Strategy;

public class StrategyTests
{
    [Fact]
    public void Should_serialize_to_Json()
    {
        var person = AutoFaker.Generate<Person>();
        person.SerializeService = new JsonSerializeService();
        person.Serialize().Should().Be($"{{\"FirstName\":\"{person.FirstName}\",\"LastName\":\"{person.LastName}\"}}");
    }
    
    [Fact]
    public void Should_serialize_to_Xml()
    {
        var person = AutoFaker.Generate<Person>();
        person.SerializeService = new XmlSerializeService();
        var expectedResult = $"<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<Person xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <FirstName>{person.FirstName}</FirstName>\r\n  <LastName>{person.LastName}</LastName>\r\n</Person>";
        person.Serialize().Should().BeEquivalentTo(expectedResult);
    }
}