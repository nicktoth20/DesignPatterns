namespace DesignPatterns.Behavior.Chain_of_Responsibility;

public interface IHandler<T> where T : class
{
    IHandler<T> SetSuccessor(IHandler<T> successor);
    void Handle(T request);
}