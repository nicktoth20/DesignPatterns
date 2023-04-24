namespace DesignPatterns.Behavior.State;

public class BankAccount
{
    public BankAccountState BankAccountState { get; set; }
    public decimal Balance => BankAccountState.Balance;

    public void Deposit(decimal amount)
    {
        BankAccountState.Deposit(amount);
    }

    public void Withdrawl(decimal amount)
    {
        BankAccountState.Withdraw(amount);
    }
}