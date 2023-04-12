namespace DesignPatterns.Behavior.Memento;

public class AddEmployeeToManagerList : ICommand
{
    private readonly IEmployeeManagerRepository _employeeManagerRepository;
    private int _managerId;
    private Employee? _employee;

    public AddEmployeeToManagerList(IEmployeeManagerRepository employeeManagerRepository, int managerId, Employee? employee)
    {
        _employeeManagerRepository = employeeManagerRepository;
        _managerId = managerId;
        _employee = employee;
    }

    public AddEmployeeToManagerListMemento CreateMemento()
    {
        return new AddEmployeeToManagerListMemento(_managerId, _employee);
    }

    public void RestoreMemento(AddEmployeeToManagerListMemento memento)
    {
        _managerId = memento.ManagerId;
        _employee = memento.Employee;
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