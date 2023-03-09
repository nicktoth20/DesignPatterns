using DesignPatterns.Creation.Abstract_Factory;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Creation.Abstract_Factory;

public class AbstractFactoryTests
{
    [Fact]
    public void Should_calculate_correct_cost_for_Belgium()
    {
        var factory = new BelgiumShoppingCartPurchaseFactory();
        var shoppingCart = new ShoppingCart(factory);
        shoppingCart.CalculateTotalCost(156.75M).Should().Be(145.40M);
    }
    
    [Fact]
    public void Should_calculate_correct_cost_for_BelgiumFrance()
    {
        var factory = new FranceShoppingCartPurchaseFactory();
        var shoppingCart = new ShoppingCart(factory);
        shoppingCart.CalculateTotalCost(156.75M).Should().Be(166.075M);
    }
}