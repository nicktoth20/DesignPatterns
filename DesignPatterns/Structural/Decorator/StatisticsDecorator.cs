namespace DesignPatterns.Structural.Decorator;

public class StatisticsDecorator : MailServiceDecoratorBase
{
    public int SuccessfulMessages = 0;
    public int FailedMessages = 0;
    
    public StatisticsDecorator(IMailService mailService) : base(mailService)
    {
    }

    public override bool SendMail(string message)
    {
        if (base.SendMail(message))
        {
            SuccessfulMessages++;
            return true;
        };
        FailedMessages++;
        return false;
    }
}