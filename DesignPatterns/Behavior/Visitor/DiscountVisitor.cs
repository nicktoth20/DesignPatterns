namespace DesignPatterns.Behavior.Visitor;

public class DiscountVisitor : IVisitor
{
    public decimal TotalDiscountGiven { get; set; }
    
    private void VisitCustomer(Customer customer)
    {
        var discount = customer.AmountOrdered / 10;
        customer.Discount = discount;
        TotalDiscountGiven += discount;
    }

    private void VisitEmployee(Employee employee)
    {
        var discount = employee.YearsEmployed < 10 ? 100 : 200;
        employee.Discount = discount;
        TotalDiscountGiven += discount;
    }

    public void Visit(IElement element)
    {
        if (element is Customer customer)
        {
            VisitCustomer(customer);
        }
        else if (element is Employee employee)
        {
            VisitEmployee(employee);
        }
    }
}