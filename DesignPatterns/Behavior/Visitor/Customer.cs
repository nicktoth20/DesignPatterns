namespace DesignPatterns.Behavior.Visitor;

// The intent of this pattern is to represent an operation to be performed on the elements of an object structure.
// Visitor lets you define a new operation without changing the classes of the elements on which it operates.

public class Customer : IElement
{
    public decimal AmountOrdered { get; private set; }
    public decimal Discount { get; set; }
    public string Name { get; private set; }

    public Customer(string name, decimal amountOrdered)
    {
        Name = name;
        AmountOrdered = amountOrdered;
    }
    public void Accept(IVisitor visitor)
    {
        // visitor.VisitCustomer(this);
        visitor.Visit(this);
        Console.WriteLine($"Visited {nameof(Customer)} {Name}, discount given: {Discount}");
    }
}