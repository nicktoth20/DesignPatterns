namespace DesignPatterns.Behavior.Visitor;

public class Container
{
    public List<Employee> Employees { get; set; }
    public List<Customer> Customers { get; set; }

    public void Accept(IVisitor visitor)
    {
        foreach (var employee in Employees)
        {
            employee.Accept(visitor);
        }

        foreach (var customer in Customers)
        {
            customer.Accept(visitor);
        }
    }
}