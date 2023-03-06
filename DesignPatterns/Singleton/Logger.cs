namespace DesignPatterns.Singleton;

// The intent of the singleton pattern is to ensure that a class only has one instance, and to provide a global point of access to it
public class Logger
{
    private static Logger? _instance;

    public static Logger Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            
            return _instance;
        }
    }
    
    protected Logger()
    {
        
    }

    public void Log(string message)
    {
        Console.WriteLine($"Message to log: {message}");
    }
}