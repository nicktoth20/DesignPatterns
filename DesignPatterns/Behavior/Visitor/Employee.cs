namespace DesignPatterns.Behavior.Visitor;

public class Employee : IElement
{
    public int YearsEmployed { get; private set; }
    public decimal Discount { get; set; }
    public string Name { get; private set; }

    public Employee(string name, int yearsEmployed)
    {
        Name = name;
        YearsEmployed = yearsEmployed;
    }

    public void Accept(IVisitor visitor)
    {
        // visitor.VisitEmployee(this);
        visitor.Visit(this);
        Console.WriteLine($"Visited {nameof(Employee)} {Name}, discount given: {Discount}");
    }
}