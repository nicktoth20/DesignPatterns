namespace DesignPatterns.Behavior.Memento;

public class AddEmployeeToManagerListMemento 
{
    public int ManagerId;
    public Employee? Employee;

    public AddEmployeeToManagerListMemento(int managerId, Employee? employee)
    {
        ManagerId = managerId;
        Employee = employee;
    }
    
}