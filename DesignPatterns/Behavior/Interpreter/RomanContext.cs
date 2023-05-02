namespace DesignPatterns.Behavior.Interpreter;

public class RomanContext
{
    public int Input { get; set; }
    public string Output { get; set; } = string.Empty;

    public RomanContext(int input)
    {
        Input = input;
    }
}