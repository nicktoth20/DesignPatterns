using DesignPatterns.Factory_Method;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Factory_Method;

public class FactoryMethodTests
{
    [Theory]
    [InlineData("SALE10", 10)]
    [InlineData("SALE20", 20)]
    [InlineData("INVALID", 0)]
    public void Should_return_correct_discount_percentage_for_code(string code, int expectedDiscount)
    {
        var service = new CodeDiscountFactory(code).CreateDiscountService();

        service.DiscountPercentage.Should().Be(expectedDiscount);
    }
    
    [Theory]
    [InlineData("USA", 20)]
    [InlineData("INVALID", 10)]
    public void Should_return_correct_factory(string code, int expectedDiscount)
    {
        var service = new CountryDiscountFactory(code).CreateDiscountService();

        service.DiscountPercentage.Should().Be(expectedDiscount);
    }
}