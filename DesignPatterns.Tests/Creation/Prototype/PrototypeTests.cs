using DesignPatterns.Creation.Prototype;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Creation.Prototype;

public class PrototypeTests
{
    [Fact]
    public void Should_create_manager()
    {
        var manager = new Manager("Nick");
        
        manager.Name.Should().Be("Nick");
    }
    
    [Fact]
    public void Should_create_employee()
    {
        var manager = new Manager("Nick");
        var employee = new Employee("Batman", manager);
        
        employee.Manager.Name.Should().Be("Nick");
        employee.Name.Should().Be("Batman");
    }

    [Fact]
    public void Should_clone_manager()
    {
        var manager = new Manager("Nick");
        var newManager = manager.Clone();
        newManager.Name = "Barry";

        manager.Name.Should().Be("Nick");
        newManager.Name.Should().Be("Barry");
    }

    [Fact]
    public void Should_shallow_clone_employee()
    {
        var manager = new Manager("Nick");
        var employee = new Employee("Batman", manager);
        var newEmployee = employee.Clone();
        newEmployee.Manager.Name = "Barry";
        newEmployee.Name = "Robin";

        employee.Manager.Name.Should().Be("Barry");
        employee.Name.Should().Be("Batman");
        newEmployee.Manager.Name.Should().Be("Barry");
        newEmployee.Name.Should().Be("Robin");
    }
    
    [Fact]
    public void Should_deep_clone_employee()
    {
        var manager = new Manager("Nick");
        var employee = new Employee("Batman", manager);
        var newEmployee = employee.Clone(true);
        newEmployee.Manager.Name = "Barry";

        employee.Manager.Name.Should().Be("Nick");
        employee.Name.Should().Be("Batman");
        newEmployee.Manager.Name.Should().Be("Barry");
        newEmployee.Name.Should().Be("Batman");
    }
}