// See https://aka.ms/new-console-template for more information
using Classes;

var account = new BankAccount("Steve", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance");

account.MakeWithDrawal(500, DateTime.Now, "Rent Payment");
Console.WriteLine(account.Balance);

account.MakeWithDrawal(250, DateTime.Now, "Friend Payment");
Console.WriteLine(account.Balance);


Console.WriteLine(account.GetAccountHistory());

BankAccount invalidAccount;
try
{
    invalidAccount = new BankAccount("invalid", -55);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Exception caught creating account with negative balance");
    Console.WriteLine(e.ToString);
    return;
}

try { account.MakeWithDrawal(750, DateTime.Now, "Attempt to overdraw"); }
catch (InvalidOperationException e)
{
    Console.WriteLine("Exception caught trying to overdraw");
    Console.WriteLine(e.ToString);
}