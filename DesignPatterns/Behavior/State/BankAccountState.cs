namespace DesignPatterns.Behavior.State;

// The intent of this pattern is to allow an object to alter its behavior when its internal state changes.
// The object will appear to change its class.

public abstract class BankAccountState
{
    public BankAccount BankAccount { get; protected set; } = null!;
    public decimal Balance { get; protected set; }

    public abstract void Deposit(decimal amount);

    public abstract void Withdraw(decimal amount);
}