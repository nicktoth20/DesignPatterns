// The intent of this pattern is to define a family of algorithms, encapsulate each one, and make them interchangeable.
// Strategy lets the algorithm vary independently from clients that use it.

using Newtonsoft.Json;

namespace DesignPatterns.Behavior.Strategy;

/// <summary>
/// ConcreteStrategy
/// </summary>
public class JsonSerializeService : ISerializeService
{
    public string Serialize(Person person)
    {
        return JsonConvert.SerializeObject(person);
    }
}