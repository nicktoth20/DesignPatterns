namespace DesignPatterns.Behavior.Visitor;

public interface IVisitor
{
    // void VisitCustomer(Customer customer);
    // void VisitEmployee(Employee employee);
    void Visit(IElement element);
}