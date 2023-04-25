namespace DesignPatterns.Behavior.Iterator;

public interface IPeopleCollection
{
    IPeopleIterator CreateIterator();
}