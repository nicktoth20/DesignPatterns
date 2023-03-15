namespace DesignPatterns.Structural.Decorator;

public class OnPremiseMailService : IMailService
{
    private readonly Logger _logger;

    public OnPremiseMailService(Logger logger)
    {
        _logger = logger;
    }
    
    public bool SendMail(string message)
    {
        _logger.Log($"Message \"{message}\" sent via {nameof(OnPremiseMailService)}.");
        return true;
    }
}