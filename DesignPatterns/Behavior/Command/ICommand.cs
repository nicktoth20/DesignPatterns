namespace DesignPatterns.Behavior.Command;

public interface ICommand
{
    void Execute();
    void Undo();
    bool CanExecute();
}