using DesignPatterns.Structural.Decorator;
using FluentAssertions;
using Moq;
using Moq.AutoMock;
using Xunit;

namespace DesignPatterns.Tests.Structural.Decorator;

public class MessageDatabaseDecoratorTests
{
    [Fact]
    public void Should_send_mail()
    {
        var autoMocker = new AutoMocker();
        var message = "Message to send";
        autoMocker.Use<IMailService>(service => service.SendMail(message) == true);
        var messageDatabaseDecorator = autoMocker.CreateInstance<MessageDatabaseDecorator>();
        
        var result = messageDatabaseDecorator.SendMail(message);

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
        var messageDatabaseDecorator = autoMocker.CreateInstance<MessageDatabaseDecorator>();
        
        var result = messageDatabaseDecorator.SendMail(message);

        result.Should().BeFalse();
    }
    
    [Fact]
    public void Should_save_message_on_success()
    {
        var autoMocker = new AutoMocker();
        var message = "Message to send";
        autoMocker.Use<IMailService>(service => service.SendMail(message) == true);
        var messageDatabaseDecorator = autoMocker.CreateInstance<MessageDatabaseDecorator>();
        
        messageDatabaseDecorator.SendMail(message);

        messageDatabaseDecorator.SentMessages.Count.Should().Be(1);
        messageDatabaseDecorator.SentMessages.Should().Contain(message);
    }
    
    [Fact]
    public void Should_not_save_message_on_failure()
    {
        var autoMocker = new AutoMocker();
        var message = "Message to send";
        autoMocker.Use<IMailService>(service => service.SendMail(message) == false);
        var messageDatabaseDecorator = autoMocker.CreateInstance<MessageDatabaseDecorator>();
        
        messageDatabaseDecorator.SendMail(message);

        messageDatabaseDecorator.SentMessages.Count.Should().Be(0);
    }
}