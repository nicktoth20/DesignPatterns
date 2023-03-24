namespace DesignPatterns.Behavior.Strategy;

/// <summary>
/// Strategy
/// </summary>
public interface ISerializeService
{
    string Serialize(Person person);
}