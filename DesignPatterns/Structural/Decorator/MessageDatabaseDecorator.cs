namespace DesignPatterns.Structural.Decorator;

public class MessageDatabaseDecorator : MailServiceDecoratorBase
{
    public readonly List<string> SentMessages = new ();

    public MessageDatabaseDecorator(IMailService mailService) : base(mailService)
    {
    }

    public override bool SendMail(string message)
    {
        if (base.SendMail(message))
        {
            SentMessages.Add(message);
            return true;
        }

        return false;
    }
}