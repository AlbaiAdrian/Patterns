namespace Command;

public class BankCommand : ICommand
{
    
    private BankAccount account;
    private Action action;
    private int amount;
    private bool succeeded;

    public BankCommand(BankAccount account, Action action, int amount)
    {
        this.account = account;
        this.action = action;
        this.amount = amount;
    }


    // !!!! This command can be split in two commands, one for deposit one for withraw
    public void Execute()
    {
        switch (action)
        {
            case Action.Deposit:
                account.Deposit(amount);
                succeeded = true;
                break;
            case Action.Withdraw:
                succeeded = account.Withdraw(amount);
                break;
        }
    }

    public void Undo()
    {
        if (!succeeded) return;

        switch (action)
        {
            case Action.Deposit:
                account.Withdraw(amount);
                break;
            case Action.Withdraw:
                account.Deposit(amount);
                break;
        }
    }
}
