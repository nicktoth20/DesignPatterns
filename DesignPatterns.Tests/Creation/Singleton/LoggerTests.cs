using DesignPatterns.Creation.Singleton;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Creation.Singleton;

public class LoggerTests
{
    [Fact]
    public void Should_be_same_instance()
    {
        var logger1 = Logger.Instance;
        var logger2 = Logger.Instance;

        logger1.Should().Be(logger2);
    } 
    
    [Fact]
    public void Should_be_same_instance_when_using_thread_safe_logger()
    {
        var logger1 = ThreadSafeLogger.Instance;
        var logger2 = ThreadSafeLogger.Instance;

        logger1.Should().Be(logger2);
    } 
}