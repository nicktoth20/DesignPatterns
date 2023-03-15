namespace DesignPatterns.Structural.Decorator;

// The intent of this pattern is to attach additional responsibilities to an object dynamically. A decorator thus
// provides a flexible alternative to subclassing for extending functionality.

public class CloudMailService : IMailService
{
    private readonly Logger _logger;

    public CloudMailService(Logger logger)
    {
        _logger = logger;
    }
    
    public bool SendMail(string message)
    {
        _logger.Log($"Message \"{message}\" sent via {nameof(CloudMailService)}.");
        return true;
    }
}