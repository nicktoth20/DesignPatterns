namespace DesignPatterns.Structural.Facade;

public class CustomerDiscountBaseService
{
    public virtual double CalculateDiscountBase(int customerId)
    {
        // fake calculation for demo purposes
        return customerId > 8 ? 10 : 20;
    }
}