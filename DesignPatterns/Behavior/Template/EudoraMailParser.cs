namespace DesignPatterns.Behavior.Template;

public class EudoraMailParser : MailParser
{
    // Used for testing
    public EudoraMailParser(Logger logger) : base(logger)
    {
    }
    
    protected override void FindServer()
    {
        Logger.Log("Finding Eudora server through a custom algorithm...");
    }

    protected override void AuthenticateToServer()
    {
        Logger.Log("Connecting to Eudora");
    }
}