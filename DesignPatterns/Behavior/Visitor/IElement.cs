namespace DesignPatterns.Behavior.Visitor;

public interface IElement
{
    void Accept(IVisitor visitor);
}