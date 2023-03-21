namespace DesignPatterns.Structural.Proxy;

// The intent of this pattern is to provide a surrogate or placeholder for another object to control access to it

public class Document : IDocument
{
    public string? Title { get; set; }
    public string? Content { get; set; }
    public int AuthorId { get; set; }
    public DateTimeOffset LastAccessed { get; set; }
    private string _fileName { get; set; }

    public Document(string fileName)
    {
        _fileName = fileName;
        LoadDocument();
    }

    private void LoadDocument()
    {
        Console.WriteLine("Executing expensive action: loading a file from disk");
        // fake loading...
        Thread.Sleep(1000);

        Title = "An expensive document";
        Content = "Lots and lots of content";
        AuthorId = 1;
        LastAccessed = DateTimeOffset.UtcNow;
    }

    public void DisplayDocument()
    {
        Console.WriteLine($"Title: {Title}, Content: {Content}");
    }
}