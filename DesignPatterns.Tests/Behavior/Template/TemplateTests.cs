using DesignPatterns.Behavior.Template;
using FluentAssertions;
using Moq;
using Moq.AutoMock;
using Xunit;

namespace DesignPatterns.Tests.Behavior.Template;

public class TemplateTests
{
    [Fact]
    public void Should_parse_mail_for_Apache()
    {
        var autoMocker = new AutoMocker();
        var parser = autoMocker.CreateInstance<ApacheMailParser>();
        var identifier = "123";
        
        var result = parser.ParseMailBody(identifier);

        var logger = autoMocker.GetMock<Logger>();
        logger.Verify(l => l.Log("Parsing mail body (in template method)..."), Times.Once);
        logger.Verify(l => l.Log("Finding server..."), Times.Once);
        logger.Verify(l => l.Log("Connecting to Apache"), Times.Once);
        logger.Verify(l => l.Log("Parsing HTML mail body..."), Times.Once);
        result.Should().Be("This is the body of mail with id 123");
    }
    
    [Fact]
    public void Should_parse_mail_for_Eudora()
    {
        var autoMocker = new AutoMocker();
        var parser = autoMocker.CreateInstance<EudoraMailParser>();
        var identifier = "123";
        
        var result = parser.ParseMailBody(identifier);

        var logger = autoMocker.GetMock<Logger>();
        logger.Verify(l => l.Log("Parsing mail body (in template method)..."), Times.Once);
        logger.Verify(l => l.Log("Finding Eudora server through a custom algorithm..."), Times.Once);
        logger.Verify(l => l.Log("Connecting to Eudora"), Times.Once);
        logger.Verify(l => l.Log("Parsing HTML mail body..."), Times.Once);
        result.Should().Be("This is the body of mail with id 123");
    }
    
    [Fact]
    public void Should_parse_mail_for_Exchange()
    {
        var autoMocker = new AutoMocker();
        var parser = autoMocker.CreateInstance<ExchangeMailParser>();
        var identifier = "123";
        
        var result = parser.ParseMailBody(identifier);

        var logger = autoMocker.GetMock<Logger>();
        logger.Verify(l => l.Log("Parsing mail body (in template method)..."), Times.Once);
        logger.Verify(l => l.Log("Finding server..."), Times.Once);
        logger.Verify(l => l.Log("Connecting to Exchange"), Times.Once);
        logger.Verify(l => l.Log("Parsing HTML mail body..."), Times.Once);
        result.Should().Be("This is the body of mail with id 123");
    }
}