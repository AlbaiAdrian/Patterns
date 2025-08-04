namespace Memento;

class BankAccount
{
    private int _balance;

    public BankAccount(int initialBalance)
    {
        _balance = initialBalance;
        Console.WriteLine($"Account created with balance: {_balance}");
    }

    public IMemento Save()
    {
        return new BankAccountMemento(_balance);
    }

    public void Restore(IMemento memento)
    {
        if (memento is BankAccountMemento state)
        {
            _balance = state.Balance;
            Console.WriteLine($"State restored to balance: {_balance} (Saved at {state.GetDate()})");
        }
        else
        {
            throw new ArgumentException("Invalid memento");
        }
    }

    public void Deposit(int amount)
    {
        _balance += amount;
        Console.WriteLine($"Deposited {amount}, balance is now {_balance}");
    }

    public void Withdraw(int amount)
    {
        _balance -= amount;
        Console.WriteLine($"Withdrew {amount}, balance is now {_balance}");
    }

    public int GetBalance()
    {
        return _balance;
    }
}
