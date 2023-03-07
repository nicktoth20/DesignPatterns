namespace DesignPatterns.Factory_Method;

// The intent of the factory method pattern is to define an interface for creating an object,
// but to let subclasses decide which class to instantiate.
// Factory method lets a class defer instantiation to subclasses.
public abstract class DiscountService
{
    public abstract int DiscountPercentage { get; }
    
    public override string ToString() => GetType().Name;
}