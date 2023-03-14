namespace DesignPatterns.Structural.Bridge;

public class NoDollarCoupon : ICoupon
{
    public int CouponValue => 0;
}