namespace DesignPatterns.Behavior.Command;

// The intent of this pattern is to encapsulate a request as an object, thereby letting you parameterize clients
// with different requests, queue or log requests, and support undoable operations

public class AddEmployeeToManagerList : ICommand
{
    private readonly IEmployeeManagerRepository _employeeManagerRepository;
    private readonly int _managerId;
    private readonly Employee? _employee;

    public AddEmployeeToManagerList(IEmployeeManagerRepository employeeManagerRepository, int managerId, Employee? employee)
    {
        _employeeManagerRepository = employeeManagerRepository;
        _managerId = managerId;
        _employee = employee;
    }
    
    public void Execute()
    {
        if (_employee == null)
        {
            return;
        }
        
        _employeeManagerRepository.AddEmployee(_managerId, _employee);
    }

    public void Undo()
    {
        if (_employee == null)
        {
            return;
        }
        
        _employeeManagerRepository.RemoveEmployee(_managerId,_employee);
    }

    public bool CanExecute()
    {
        if (_employee == null)
        {
            return false;
        }
        
        // employee shouldn't be on the manager's list already
        if (_employeeManagerRepository.HasEmployee(_managerId, _employee.Id))
        {
            return false;
        }

        // other potential rule(s): ensure that an employee can only be added to one manager's list at the same time, etc.
        return true;
    }
}