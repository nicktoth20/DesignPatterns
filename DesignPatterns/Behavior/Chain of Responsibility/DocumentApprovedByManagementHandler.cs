using System.ComponentModel.DataAnnotations;

namespace DesignPatterns.Behavior.Chain_of_Responsibility;

public class DocumentApprovedByManagementHandler : IHandler<Document>
{
    private IHandler<Document>? _successor;
    public IHandler<Document> SetSuccessor(IHandler<Document> successor)
    {
        _successor = successor;
        return _successor;
    }

    public void Handle(Document document)
    {
        if (!document.ApprovedByManagement)
        {
            throw new ValidationException(
                new ValidationResult("Document must be approved by management", new List<string> { "ApprovedByManagement" }), null, null);
        }

        _successor?.Handle(document);
    }
}