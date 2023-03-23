namespace DesignPatterns.Behavior.Template;

// The intent of this pattern is to define the skeleton of an algorithm in an operation,
// deferring some steps to subclasses. It lets subclasses redefine certain steps of an
// algorithm without changing the algorithm's structure.
public abstract class MailParser
{
    protected readonly Logger Logger;

    protected MailParser(Logger logger)
    {
        Logger = logger;
    }
    
    protected virtual void FindServer()
    {
        Logger.Log("Finding server...");
    }

    protected abstract void AuthenticateToServer();

    private string ParseHtmlMailBody(string identifier)
    {
        Logger.Log("Parsing HTML mail body...");
        return $"This is the body of mail with id {identifier}";
    }

    /// <summary>
    /// Template method
    /// </summary>
    public string ParseMailBody(string identifier)
    {
        Logger.Log("Parsing mail body (in template method)...");
        FindServer();
        AuthenticateToServer();
        return ParseHtmlMailBody(identifier);
    }
}