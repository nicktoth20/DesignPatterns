namespace DesignPatterns.Creation.Abstract_Factory;

public class ShoppingCart
{
    private readonly IDiscountService _discountService;
    private readonly IShippingCostsService _shippingCostsService;

    public ShoppingCart(IShoppingCartPurchaseFactory factory)
    {
        _discountService = factory.CreateDiscountService();
        _shippingCostsService = factory.CreateShippingCostsService();
    }

    public decimal CalculateTotalCost(decimal initialCost)
    {
        return initialCost - (initialCost / 100 * _discountService.DiscountPercentage) +
               _shippingCostsService.ShippingCosts;
    }
}