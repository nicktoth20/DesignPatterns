namespace DesignPatterns.Structural.Adapter;

public class Employee
{
    public string FullName { get; }
    public decimal HeightInInches { get; }

    public Employee(string fullName, decimal height)
    {
        FullName = fullName;
        HeightInInches = height;
    }
}