namespace DesignPatterns.Creation.Prototype;

// The intent of this pattern is to specify the kinds of objects to create using a prototypical instance,
// and create new objects by copying this prototype
public abstract class Person
{
    public abstract string Name { get; set; }
    public abstract Person Clone(bool deepClone);
}