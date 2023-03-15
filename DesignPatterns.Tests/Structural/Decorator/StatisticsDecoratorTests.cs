using DesignPatterns.Structural.Decorator;
using FluentAssertions;
using Moq;
using Moq.AutoMock;
using Xunit;

namespace DesignPatterns.Tests.Structural.Decorator;

public class StatisticsDecoratorTests
{
    [Fact]
    public void Should_send_mail()
    {
        var autoMocker = new AutoMocker();
        var message = "Message to send";
        autoMocker.Use<IMailService>(service => service.SendMail(message) == true);
        var statisticsDecorator = autoMocker.CreateInstance<StatisticsDecorator>();
        
        var result = statisticsDecorator.SendMail(message);

        result.Should().BeTrue();
        autoMocker.GetMock<IMailService>()
            .Verify(l => l.SendMail("Message to send"), Times.Once);
    }
    [Fact]
    public void Should_not_send_mail_on_failure()
    {
        var autoMocker = new AutoMocker();
        var message = "Message to send";
        autoMocker.Use<IMailService>(service => service.SendMail(message) == false);
        var statisticsDecorator = autoMocker.CreateInstance<StatisticsDecorator>();
        
        var result = statisticsDecorator.SendMail(message);

        result.Should().BeFalse();
    }
    
    [Fact]
    public void Should_count_success_messages()
    {
        var autoMocker = new AutoMocker();
        var message = "Message to send";
        autoMocker.Use<IMailService>(service => service.SendMail(message) == true);
        var statisticsDecorator = autoMocker.CreateInstance<StatisticsDecorator>();
        
        statisticsDecorator.SendMail(message);
        statisticsDecorator.SendMail(message);

        statisticsDecorator.SuccessfulMessages.Should().Be(2);
        statisticsDecorator.FailedMessages.Should().Be(0);
    }
    
    [Fact]
    public void Should_count_failed_messages()
    {
        var autoMocker = new AutoMocker();
        var message = "Message to send";
        autoMocker.Use<IMailService>(service => service.SendMail(message) == false);
        var statisticsDecorator = autoMocker.CreateInstance<StatisticsDecorator>();
        
        statisticsDecorator.SendMail(message);
        statisticsDecorator.SendMail(message);

        statisticsDecorator.SuccessfulMessages.Should().Be(0);
        statisticsDecorator.FailedMessages.Should().Be(2);
    }
}