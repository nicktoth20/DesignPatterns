namespace DesignPatterns.Structural.Adapter;

public class EmployeeAdapter : IEmployeeAdapter
{
    private ExternalSystem _externalSystem { get; }

    public EmployeeAdapter(ExternalSystem externalSystem)
    {
        _externalSystem = externalSystem;
    }
        
    public Employee GetEmployee()
    {
        var personFromExternalSystem = _externalSystem.GetPerson();
        var adaptedName = $"{personFromExternalSystem.LastName}, {personFromExternalSystem.FirstName}";
        var heightInInches = personFromExternalSystem.HeightInCentimeters / 2.54M;
        return new Employee(adaptedName, heightInInches);
    }
}