namespace DesignPatterns.Structural.Bridge;

public class VegetarianMenu : IMenu
{
    public VegetarianMenu(ICoupon? coupon = null) : base(coupon ?? new NoDollarCoupon())
    {
    }

    public override int CalculatePrice(int initialCost)
    {
        return initialCost - Coupon.CouponValue;
    }
}