namespace DesignPatterns.Structural.Adapter;

public class ExternalSystem
{
    private Person _person;

    public void AddPerson(string firstName, string lastName, decimal height)
    {
        _person = new Person(firstName, lastName, height);
    }
    
    public Person GetPerson()
    {
        return _person;
    }
}