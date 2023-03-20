using DesignPatterns.Structural.Facade;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Structural.Facade;

public class CustomerDiscountBaseServiceTests
{
    
    [Theory]
    [InlineData(7, 20)]
    [InlineData(8, 20)]
    [InlineData(9, 10)]
    public void Should_calculate_discount_for_customer(int customerId, double expectedResult)
    {
        var service = new CustomerDiscountBaseService();

        service.CalculateDiscountBase(customerId).Should().Be(expectedResult);
    }
}