namespace DesignPatterns.Creation.Abstract_Factory;

public interface IShoppingCartPurchaseFactory
{
    IDiscountService CreateDiscountService();
    IShippingCostsService CreateShippingCostsService();
}