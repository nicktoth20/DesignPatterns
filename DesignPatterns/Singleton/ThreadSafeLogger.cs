namespace DesignPatterns.Singleton;

public class ThreadSafeLogger
{
    private static readonly Lazy<ThreadSafeLogger> _lazyLogger = new Lazy<ThreadSafeLogger>(() => new ThreadSafeLogger());

    public static ThreadSafeLogger Instance => _lazyLogger.Value;

    protected ThreadSafeLogger()
    {
        
    }

    public void Log(string message)
    {
        Console.WriteLine($"Message to log: {message}");
    }
}