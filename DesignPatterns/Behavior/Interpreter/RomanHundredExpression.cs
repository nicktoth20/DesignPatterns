namespace DesignPatterns.Behavior.Interpreter;

/// <summary>
/// Terminal Expression
/// </summary>
public class RomanHundredExpression : RomanExpression
{
    public override void Interpret(RomanContext value)
    {
        while ((value.Input - 900) >= 0)
        {
            value.Output += "CM";
            value.Input -= 900;
        }
        while ((value.Input - 500) >= 0)
        {
            value.Output += "D";
            value.Input -= 500;
        }
        while ((value.Input - 400) >= 0)
        {
            value.Output += "CD";
            value.Input -= 400;
        }
        while ((value.Input - 100) >= 0)
        {
            value.Output += "C";
            value.Input -= 100;
        }
    }
}