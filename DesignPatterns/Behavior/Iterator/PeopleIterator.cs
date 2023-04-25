namespace DesignPatterns.Behavior.Iterator;

public class PeopleIterator : IPeopleIterator
{
    private readonly PeopleCollection _peopleCollection;
    private int _current = 0;

    public PeopleIterator(PeopleCollection peopleCollection)
    {
        _peopleCollection = peopleCollection;
    }
    
    public Person First()
    {
        _current = 0;
        return _peopleCollection.OrderBy(p => p.Name).ToList()[_current];
    }

    public Person Next()
    {
        _current++;
        if (!IsDone)
        {
            return _peopleCollection.OrderBy(p => p.Name).ToList()[_current];
        }

        return null;
    }

    public bool IsDone => _current >= _peopleCollection.Count;
    public Person CurrentItem => _peopleCollection.OrderBy(p => p.Name).ToList()[_current];
}