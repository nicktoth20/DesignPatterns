namespace DesignPatterns.Behavior.Iterator;

// The intent of this pattern is to provide a way to access the elements of an aggregate object sequentially
// without exposing its underlying representation

public class PeopleCollection : List<Person>, IPeopleCollection
{
    public IPeopleIterator CreateIterator()
    {
        return new PeopleIterator(this);
    }
}