namespace DesignPatterns.Behavior.Interpreter;

// The intent of this pattern is to, given a language, define a representation for its grammar along with an 
// interpreter that uses the representation to interpret sentences in the language

public abstract class RomanExpression
{
    public abstract void Interpret(RomanContext value);
}