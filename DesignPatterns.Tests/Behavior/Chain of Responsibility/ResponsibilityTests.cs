using System.ComponentModel.DataAnnotations;
using DesignPatterns.Behavior.Chain_of_Responsibility;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Behavior.Chain_of_Responsibility;

public class ResponsibilityTests
{
    [Fact]
    public void Should_be_valid_when_all_fields_are_valid()
    {
        var validDocument = new Document("Art of Unit Testing", DateTimeOffset.Now, true, true);

        var documentHandlerChain = new DocumentTitleHandler();
        documentHandlerChain
            .SetSuccessor(new DocumentLastModifiedHandler())
            .SetSuccessor(new DocumentApprovedByLitigationHandler())
            .SetSuccessor(new DocumentApprovedByManagementHandler());
        
        var act = () => documentHandlerChain.Handle(validDocument);

        act.Should().NotThrow();
    }
    
    [Fact]
    public void Should_throw_exception_when_title_not_set()
    {
        var validDocument = new Document("", DateTimeOffset.Now, true, true);

        var documentHandlerChain = new DocumentTitleHandler();
        documentHandlerChain
            .SetSuccessor(new DocumentLastModifiedHandler())
            .SetSuccessor(new DocumentApprovedByLitigationHandler())
            .SetSuccessor(new DocumentApprovedByManagementHandler());
        
        var act = () => documentHandlerChain.Handle(validDocument);

        var message = act.Should().Throw<ValidationException>();
        message.WithMessage("Title must be filled out");
    }
    
    [Fact]
    public void Should_throw_exception_when_last_modified_not_within_30_days()
    {
        var validDocument = new Document("Art of Unit Tests", DateTimeOffset.Now.AddDays(-31), true, true);

        var documentHandlerChain = new DocumentTitleHandler();
        documentHandlerChain
            .SetSuccessor(new DocumentLastModifiedHandler())
            .SetSuccessor(new DocumentApprovedByLitigationHandler())
            .SetSuccessor(new DocumentApprovedByManagementHandler());
        
        var act = () => documentHandlerChain.Handle(validDocument);

        var message = act.Should().Throw<ValidationException>();
        message.WithMessage("Document must be modified in the last 30 days");
    }
    
    [Fact]
    public void Should_throw_exception_when_not_approved_by_litigation()
    {
        var validDocument = new Document("Art of Unit Tests", DateTimeOffset.Now, false, true);

        var documentHandlerChain = new DocumentTitleHandler();
        documentHandlerChain
            .SetSuccessor(new DocumentLastModifiedHandler())
            .SetSuccessor(new DocumentApprovedByLitigationHandler())
            .SetSuccessor(new DocumentApprovedByManagementHandler());
        
        var act = () => documentHandlerChain.Handle(validDocument);

        var message = act.Should().Throw<ValidationException>();
        message.WithMessage("Document must be approved by litigation");
    }
    
    [Fact]
    public void Should_throw_exception_when_not_approved_by_management()
    {
        var validDocument = new Document("Art of Unit Tests", DateTimeOffset.Now, true, false);

        var documentHandlerChain = new DocumentTitleHandler();
        documentHandlerChain
            .SetSuccessor(new DocumentLastModifiedHandler())
            .SetSuccessor(new DocumentApprovedByLitigationHandler())
            .SetSuccessor(new DocumentApprovedByManagementHandler());
        
        var act = () => documentHandlerChain.Handle(validDocument);

        var message = act.Should().Throw<ValidationException>();
        message.WithMessage("Document must be approved by management");
    }
}