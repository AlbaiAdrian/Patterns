namespace Memento;

class BankAccountMemento : IMemento
{
    public int Balance { get; }
    public DateTime Timestamp { get; }

    public BankAccountMemento(int balance)
    {
        Balance = balance;
        Timestamp = DateTime.Now;
    }

    public DateTime GetDate()
    {
        return Timestamp;
    }

    public string GetName()
    {
        return $"{Timestamp:HH:mm:ss} - Balance: {Balance}";
    }
}
