namespace DesignPatterns.Behavior.Iterator;

public interface IPeopleIterator
{
    Person First();
    Person Next();
    bool IsDone { get; }
    Person CurrentItem { get; }
}