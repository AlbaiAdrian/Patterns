// See https://aka.ms/new-console-template for more information
using Command;
using Action = Command.Action;

Console.WriteLine("Hello, Command!");


var account = new BankAccount();
var commands = new List<ICommand>
            {
                new BankCommand(account, Action.Deposit, 100),
                new BankCommand(account, Action.Withdraw, 50),
                new BankCommand(account, Action.Withdraw, 1000) // Should fail
            };

Console.WriteLine("\n== Executing Commands ==");
foreach (var cmd in commands)
    cmd.Execute();

Console.WriteLine("\n== Undoing Commands ==");
foreach (var cmd in ((IEnumerable<ICommand>)commands).Reverse())
    cmd.Undo();

Console.WriteLine($"\nFinal Account State: {account}");