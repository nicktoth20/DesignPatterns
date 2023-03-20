using DesignPatterns.Structural.Facade;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Structural.Facade;

public class DayOfTheWeekFactorServiceTests
{
    [Theory]
    [InlineData(DayOfWeek.Sunday, 0.8)]
    [InlineData(DayOfWeek.Saturday, 0.8)]
    [InlineData(DayOfWeek.Monday, 1.2)]
    [InlineData(DayOfWeek.Tuesday, 1.2)]
    [InlineData(DayOfWeek.Wednesday, 1.2)]
    [InlineData(DayOfWeek.Thursday, 1.2)]
    [InlineData(DayOfWeek.Friday, 1.2)]
    public void Should_return_correct_percentage_for_each_day_of_the_week(DayOfWeek dayOfWeek,
        double expectedPercentage)
    {
        var service = new DayOfTheWeekFactorService();

        service.CalculateDayOfTheWeekFactor(dayOfWeek).Should().Be(expectedPercentage);
    }
}