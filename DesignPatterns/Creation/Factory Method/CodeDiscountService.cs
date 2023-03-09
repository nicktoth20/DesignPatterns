namespace DesignPatterns.Creation.Factory_Method;

public class CodeDiscountService : DiscountService
{
    private readonly string _code;

    public CodeDiscountService(string code)
    {
        _code = code;
    }

    public override int DiscountPercentage
    {
        get
        {
            return _code switch
            {
                "SALE10" => 10,
                "SALE20" => 20,
                _ => 0
            };
        }
    }
}