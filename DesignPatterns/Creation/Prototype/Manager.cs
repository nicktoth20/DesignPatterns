using Newtonsoft.Json;

namespace DesignPatterns.Creation.Prototype;

public class Manager : Person
{
    public override string Name { get; set; }

    public Manager(string name)
    {
        Name = name;
    }
    
    public override Person Clone(bool deepClone = false)
    {
        // Shallow copy
        return deepClone ? DeepClone() : (Person)MemberwiseClone();
    }
    
    private Person DeepClone()
    {
        var jsonObject = JsonConvert.SerializeObject(this);
        return JsonConvert.DeserializeObject<Manager>(jsonObject);
    }
}