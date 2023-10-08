using Classes;

var account = new BankAccount("Nnaemeka", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance");


account.MakeWithdrawal(10000, DateTime.Now, "Rent Payment");
Console.WriteLine(account.Balance);
account.MakeDeposit(100, DateTime.Now, "From Njideka");
Console.WriteLine(account.Balance);


Console.WriteLine(account.GetAccountHistory());

var account2 = new BankAccount("Elizabeth", 10000);
Console.WriteLine($"Account {account2.Number} was created for {account2.Owner} with {account2.Balance} initial balance");

account2.MakeWithdrawal(500, DateTime.Now, "Rent Payment");
Console.WriteLine(account2.Balance);
account2.MakeDeposit(100, DateTime.Now, "From Njideka");
Console.WriteLine(account2.Balance);

Console.WriteLine(account2.GetAccountHistory());

try
{
    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
}
catch (InvalidOperationException e)
{
    Console.WriteLine("Exception caught trying to overdraw");
    Console.WriteLine(e.ToString());
}

BankAccount invalidAccount;
try
{
    invalidAccount = new BankAccount("invalid", -55);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Exception caught creating account with negative balance");
    Console.WriteLine(e.ToString());
    return;
}
