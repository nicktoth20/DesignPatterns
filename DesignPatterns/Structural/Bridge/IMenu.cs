namespace DesignPatterns.Structural.Bridge;

// The intent of this pattern is to decouple an abstraction from its implementation so the two can very independently

public abstract class IMenu
{
    internal readonly ICoupon? Coupon = null;
    public abstract int CalculatePrice(int initialCost);

    protected IMenu(ICoupon? coupon)
    {
        Coupon = coupon;
    }
}