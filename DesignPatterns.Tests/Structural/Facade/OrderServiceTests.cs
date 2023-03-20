using DesignPatterns.Structural.Facade;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Structural.Facade;

public class OrderServiceTests
{
    [Theory]
    [InlineData(4, false)]
    [InlineData(5, false)]
    [InlineData(6, true)]
    public void Should_indicate_if_customer_has_enough_orders(int customerId, bool expectedResult)
    {
        var service = new OrderService();

        service.HasEnoughOrders(customerId).Should().Be(expectedResult);
    }
}