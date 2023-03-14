namespace DesignPatterns.Structural.Bridge;

public class MeatMenu : IMenu
{
    public MeatMenu(ICoupon? coupon = null) : base(coupon ?? new NoDollarCoupon())
    {
    }

    public override int CalculatePrice(int initialCost)
    {
        return initialCost - Coupon.CouponValue;
    }
}