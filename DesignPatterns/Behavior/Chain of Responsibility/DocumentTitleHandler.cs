using System.ComponentModel.DataAnnotations;

namespace DesignPatterns.Behavior.Chain_of_Responsibility;

public class DocumentTitleHandler : IHandler<Document>
{
    private IHandler<Document>? _successor;
    public IHandler<Document> SetSuccessor(IHandler<Document> successor)
    {
        _successor = successor;
        return _successor;
    }

    public void Handle(Document document)
    {
        if (document.Title == string.Empty)
        {
            throw new ValidationException(
                new ValidationResult("Title must be filled out", new List<string> { "Title" }), null, null);
        }

        _successor?.Handle(document);
    }
}