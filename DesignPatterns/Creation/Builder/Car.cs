using System.Text;

namespace DesignPatterns.Creation.Builder;

// The intent of the builder pattern is to separate the construction of a complex object from its representation.
// By doing so, the same construction process can create different representations.
public class Car
{
    private readonly List<string> _parts = new();
    private readonly string _carType;

    public Car(string carType)
    {
        _carType = carType;
    }

    public void AddPart(string part)
    {
        _parts.Add(part);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        foreach (var part in _parts)
        {
            sb.Append($"Car of type {_carType} has part {part}.");
        }

        return sb.ToString();
    }
}