namespace DesignPatterns.Behavior.Memento;

public interface ICommand
{
    void Execute();
    void Undo();
    bool CanExecute();
}