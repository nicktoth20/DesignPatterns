using System.ComponentModel.DataAnnotations;

namespace DesignPatterns.Behavior.Chain_of_Responsibility;

public class DocumentApprovedByLitigationHandler : IHandler<Document>
{
    private IHandler<Document>? _successor;
    public IHandler<Document> SetSuccessor(IHandler<Document> successor)
    {
        _successor = successor;
        return _successor;
    }

    public void Handle(Document document)
    {
        if (!document.ApprovedByLitigation)
        {
            throw new ValidationException(
                new ValidationResult("Document must be approved by litigation", new List<string> { "ApprovedByLitigation" }), null, null);
        }

        _successor?.Handle(document);
    }
}