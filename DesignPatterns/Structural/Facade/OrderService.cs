namespace DesignPatterns.Structural.Facade;

// The intent of this pattern is to provide a unified interface to a set of interfaces in a subsystem.
// It defines a higher-level interface that makes the subsystem easier to user.

public class OrderService
{
    public virtual bool HasEnoughOrders(int customerId)
    {
        // fake calculation for demo purposes.
        return customerId > 5;
    }
}