namespace DesignPatterns.Creation.Factory_Method;

public interface IDiscountFactory
{
    public DiscountService CreateDiscountService();
}