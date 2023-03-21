namespace DesignPatterns.Structural.Proxy;

public class DocumentProxy : IDocument
{
    private Lazy<Document> _document;

    public DocumentProxy(string fileName)
    {
        _document = new Lazy<Document>(() => new Document(fileName));
    }

    public void DisplayDocument()
    {
        _document.Value.DisplayDocument();
    }
}