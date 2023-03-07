namespace DesignPatterns.Factory_Method;

public interface IDiscountFactory
{
    public DiscountService CreateDiscountService();
}