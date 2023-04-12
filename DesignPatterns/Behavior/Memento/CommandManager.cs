namespace DesignPatterns.Behavior.Memento;

public class CommandManager
{
    private readonly Stack<AddEmployeeToManagerListMemento> _mementos = new();
    private AddEmployeeToManagerList? _command;

    public void Invoke(ICommand command)
    {
        // if the command has not been stored yet, store it - we will reuse it instead of storing different instances
        if (_command == null)
        {
            _command = (AddEmployeeToManagerList)command;
        }
        
        if (command.CanExecute())
        {
            command.Execute();
            _mementos.Push(((AddEmployeeToManagerList)command).CreateMemento());
        }
    }

    public void Undo()
    {
        if (_mementos.Any())
        {
            _command?.RestoreMemento(_mementos.Pop());
            _command?.Undo();
        }
    }

    public void UndoAll()
    {
        while (_mementos.Any())
        {
            _command?.RestoreMemento(_mementos.Pop());
            _command?.Undo();
        }
    }
}