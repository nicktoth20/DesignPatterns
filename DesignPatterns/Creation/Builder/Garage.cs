namespace DesignPatterns.Creation.Builder;

public class Garage
{
    private CarBuilder? _carBuilder;

    public Garage()
    {
    }

    public void Build(CarBuilder carBuilder)
    {
        _carBuilder = carBuilder;
        _carBuilder.BuildEngine();
        _carBuilder.BuildFrame();
    }

    public string? Show()
    {
        return _carBuilder?.Car.ToString();
    }
}