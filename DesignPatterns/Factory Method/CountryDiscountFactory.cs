namespace DesignPatterns.Factory_Method;

public class CountryDiscountFactory : IDiscountFactory
{
    private readonly string _countryIdentifier;
    
    public CountryDiscountFactory(string countryIdentifier)
    {
        _countryIdentifier = countryIdentifier;
    }
    
    public DiscountService CreateDiscountService() => new CountryDiscountService(_countryIdentifier);
}