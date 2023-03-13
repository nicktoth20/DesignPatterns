namespace DesignPatterns.Structural.Adapter;

// The intent of this pattern is to convert the interface of a class into another interface clients expect.
// Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.

public class Person
{
    public string FirstName { get; }
    public string LastName { get; }
    public decimal HeightInCentimeters { get; }

    public Person(string firstName, string lastName, decimal height)
    {
        FirstName = firstName;
        LastName = lastName;
        HeightInCentimeters = height;
    }
}