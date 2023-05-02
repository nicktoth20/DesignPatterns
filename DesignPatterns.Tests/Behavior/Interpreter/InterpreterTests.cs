using DesignPatterns.Behavior.Interpreter;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Behavior.Interpreter;

public class InterpreterTests
{
    [Theory]
    [InlineData(5, "V")]
    [InlineData(365, "CCCLXV")]
    public void Should_convert_to_roman_numerals(int input, string output)
    {
        var expressions = new List<RomanExpression>
        {
            new RomanHundredExpression(),
            new RomanTenExpression(),
            new RomanOneExpression()
        };

        var context = new RomanContext(input);
        foreach (var expression in expressions)
        {
            expression.Interpret(context);
        }

        context.Output.Should().Be(output);
    }
}