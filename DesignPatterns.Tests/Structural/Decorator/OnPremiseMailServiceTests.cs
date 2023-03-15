using DesignPatterns.Structural.Decorator;
using FluentAssertions;
using Moq;
using Moq.AutoMock;
using Xunit;

namespace DesignPatterns.Tests.Structural.Decorator;

public class OnPremiseMailServiceTests
{
    [Fact]
    public void Should_send_mail()
    {
        var autoMocker = new AutoMocker();
        var cloudMailService = autoMocker.CreateInstance<OnPremiseMailService>();
        
        var result = cloudMailService.SendMail("Message to send");

        result.Should().BeTrue();
        autoMocker.GetMock<Logger>()
            .Verify(l => l.Log("Message \"Message to send\" sent via OnPremiseMailService."), Times.Once);
    }
}