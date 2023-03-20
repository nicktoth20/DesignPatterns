using DesignPatterns.Structural.Facade;
using FluentAssertions;
using Moq;
using Moq.AutoMock;
using Xunit;

namespace DesignPatterns.Tests.Structural.Facade;

public class DiscountFacadeTests
{
    [Fact]
    public void Should_not_give_discount_if_customer_does_not_have_enough_orders()
    {
        var autoMocker = new AutoMocker();
        var customerId = 100;

        autoMocker.Use<OrderService>(s => s.HasEnoughOrders(customerId) == false);
        var facade = autoMocker.CreateInstance<DiscountFacade>();

        facade.CalculateDiscountPercentage(customerId).Should().Be(0);
    }
    
    [Fact]
    public void Should_give_discount_when_user_has_enough_orders()
    {
        var autoMocker = new AutoMocker();
        var customerId = 100;

        autoMocker.Use<IDateTimeWrapper>(s => s.GetDayOfWeek() == DayOfWeek.Friday);
        autoMocker.Use<OrderService>(s => s.HasEnoughOrders(customerId) == true);
        autoMocker.Use<CustomerDiscountBaseService>(s => s.CalculateDiscountBase(customerId) == 10);
        autoMocker.Use<DayOfTheWeekFactorService>(s => s.CalculateDayOfTheWeekFactor(DayOfWeek.Friday) == 1.2);
        var facade = autoMocker.CreateInstance<DiscountFacade>();

        facade.CalculateDiscountPercentage(customerId).Should().Be(12);
    }
}