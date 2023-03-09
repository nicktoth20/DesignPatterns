namespace DesignPatterns.Creation.Builder;

public class MiniBuilder : CarBuilder
{
    public MiniBuilder() : base("Mini")
    {
    }

    public override void BuildEngine()
    {
        Car.AddPart("'not a V8");
    }

    public override void BuildFrame()
    {
        Car.AddPart("3 doors with a stripe");
    }
}