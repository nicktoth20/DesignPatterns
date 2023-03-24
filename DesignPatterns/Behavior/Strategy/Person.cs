using System.Xml.Serialization;

namespace DesignPatterns.Behavior.Strategy;

/// <summary>
/// Strategy as a property
/// </summary>
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    [XmlIgnore]
    [Newtonsoft.Json.JsonIgnore]
    public ISerializeService? SerializeService { get; set; }

    public string? Serialize()
    {
        return SerializeService?.Serialize(this);
    }
}

///// <summary>
///// Strategy passed in which is more common
///// </summary>
// public class Person
// {
//     public string FirstName { get; set; }
//     public string LastName { get; set; }
//
//     public string Serialize(ISerializeService serializeService)
//     {
//         return serializeService.Serialize(this);
//     }
// }