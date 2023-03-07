namespace DesignPatterns.Factory_Method;

public class CodeDiscountFactory : IDiscountFactory
{
    private readonly string _code;
    
    public CodeDiscountFactory(string code)
    {
        _code = code;
    }
    
    public DiscountService CreateDiscountService() => new CodeDiscountService(_code);
}