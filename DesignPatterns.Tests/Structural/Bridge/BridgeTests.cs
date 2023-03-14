using Xunit;
using DesignPatterns.Structural.Bridge;
using FluentAssertions;

namespace DesignPatterns.Tests.Structural.Bridge;

public class BridgeTests
{
    [Fact]
    public void Should_create_meat_menu_with_coupon()
    {
        var oneDollarCoupon = new OneDollarCoupon();
        
        var meatMenu = new MeatMenu(oneDollarCoupon);
        
        meatMenu.CalculatePrice(30).Should().Be(29);
    }
    
    [Fact]
    public void Should_create_vegetarian_menu_with_coupon()
    {
        var twoDollarCoupon = new TwoDollarCoupon();
        
        var vegetarianMenu = new VegetarianMenu(twoDollarCoupon);
        
        vegetarianMenu.CalculatePrice(20).Should().Be(18);
    }
    
    [Fact]
    public void Should_create_menu_with_no_coupon()
    {
        var noDollarCoupon = new NoDollarCoupon();
        
        var vegetarianMenu = new VegetarianMenu(noDollarCoupon);
        
        vegetarianMenu.CalculatePrice(20).Should().Be(20);
    }
    
    [Fact]
    public void Should_handle_menu_without_a_coupon()
    {
        var vegetarianMenu = new VegetarianMenu();
        vegetarianMenu.CalculatePrice(20).Should().Be(20);
        
        var meatMenu = new MeatMenu();
        meatMenu.CalculatePrice(30).Should().Be(30);
    }
}