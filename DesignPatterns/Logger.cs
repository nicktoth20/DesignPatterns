namespace DesignPatterns;

public class Logger
{
    public virtual void Log(string message)
    {
        Console.WriteLine(message);
    }
}