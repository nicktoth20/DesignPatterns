namespace DesignPatterns.Behavior.Chain_of_Responsibility;

// The intent of this pattern is to avoid coupling the sender of a request to its receiver by giving more than one
// object a chance to handle the request. It does that by chaining the receiving objects and passing the request
// along the chain until an object handles it.

public class Document
{
    public string Title { get; set; }
    public DateTimeOffset LastModified { get; set; }
    public bool ApprovedByLitigation { get; set; }
    public bool ApprovedByManagement { get; set; }

    public Document(string title, DateTimeOffset lastModified, bool approvedByLitigation, bool approvedByManagement)
    {
        Title = title;
        LastModified = lastModified;
        ApprovedByLitigation = approvedByLitigation;
        ApprovedByManagement = approvedByManagement;
    }
}