namespace DesignPatterns.Behavior.Template;

public class ExchangeMailParser : MailParser
{
    // Used for testing
    public ExchangeMailParser(Logger logger) : base(logger)
    {
    }
    
    protected override void AuthenticateToServer()
    {
        Logger.Log("Connecting to Exchange");
    }
}