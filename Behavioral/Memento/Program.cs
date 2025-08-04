// See https://aka.ms/new-console-template for more information
using Memento;

Console.WriteLine("Hello, Memento!");

var account = new BankAccount(100);
var history = new BankAccountHistory();

history.Push(account.Save());

account.Deposit(50);
history.Push(account.Save());

account.Withdraw(30);
Console.WriteLine($"Current balance: {account.GetBalance()}");

history.ShowHistory();

Console.WriteLine("\nUndoing last operation...");
if (history.CanUndo)
    account.Restore(history.Pop());

Console.WriteLine("\nUndoing one more operation...");
if (history.CanUndo)
    account.Restore(history.Pop());

Console.WriteLine($"\nFinal balance: {account.GetBalance()}");