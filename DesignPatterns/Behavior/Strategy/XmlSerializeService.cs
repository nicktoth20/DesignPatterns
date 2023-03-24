using System.Xml.Serialization;

namespace DesignPatterns.Behavior.Strategy;

/// <summary>
/// ConcreteStrategy
/// </summary>
public class XmlSerializeService : ISerializeService
{
    public string Serialize(Person person)
    {
        var serializer = new XmlSerializer(typeof(Person));
        using var writer = new StringWriter();
        serializer.Serialize(writer, person);
        return writer.ToString();
    }
}