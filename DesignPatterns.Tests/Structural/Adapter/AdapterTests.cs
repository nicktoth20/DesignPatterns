using FluentAssertions;
using Xunit;
using DesignPatterns.Structural.Adapter;

namespace DesignPatterns.Tests.Structural.Adapter;

public class Adapter
{
    [Fact]
    public void Should_adapter_user_to_employee()
    {
        var externalSystem = new ExternalSystem();
        externalSystem.AddPerson("Bruce", "Wayne", 187.96M);
        var personAdapter = new EmployeeAdapter(externalSystem);
        
        var employee = personAdapter.GetEmployee();

        employee.FullName.Should().Be("Wayne, Bruce");
        employee.HeightInInches.Should().Be(74);
    }
}