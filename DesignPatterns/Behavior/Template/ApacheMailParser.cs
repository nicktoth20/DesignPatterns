namespace DesignPatterns.Behavior.Template;

public class ApacheMailParser : MailParser
{
    // Used for testing
    public ApacheMailParser(Logger logger) : base(logger)
    {
    }
    
    protected override void AuthenticateToServer()
    {
        Logger.Log("Connecting to Apache");
    }
}