using Newtonsoft.Json;

namespace DesignPatterns.Creation.Prototype;

public class Employee : Person
{
    public override string Name { get; set; }
    public Manager Manager { get; set; }

    public Employee(string name, Manager manager)
    {
        Name = name;
        Manager = manager;
    }
    
    public override Employee Clone(bool deepClone = false)
    {
        // Shallow copy; will only copy Name, not Manager
        return deepClone ? DeepClone() : (Employee)MemberwiseClone();
    }
    
    private Employee DeepClone()
    {
        var jsonObject = JsonConvert.SerializeObject(this);
        return JsonConvert.DeserializeObject<Employee>(jsonObject);
    }
}