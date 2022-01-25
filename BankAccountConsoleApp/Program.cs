// See https://aka.ms/new-console-template for more information
// video https://www.youtube.com/watch?v=BM4CHBmAPh4&list=PLdo4fOcmZ0oVxKLQCHpiUWun7vlJJvUiN
// 17 of 19
// 18 of 19
// 19 of 19
using BankAccountConsoleApp.Models;

var Account = new BankAccount("jm", 1000);
Console.WriteLine($"Account {Account.Number} was created for {Account.Owner} with {Account.Balance}.");
Account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
Console.WriteLine(Account.Balance);
Account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
Console.WriteLine(Account.Balance);

Console.WriteLine(Account.GetAccountHistory());

////Test that the initial balances must be positive.
//BankAccount invalidAccount;
//try
//{
//    invalidAccount = new BankAccount("invalid", -55);
//}
//catch (ArgumentOutOfRangeException e)
//{
//    Console.WriteLine("Exception caught creating account with negative balance");
//    Console.WriteLine(e.ToString());
//    return;
//}

// Test for a negative balance.
//try
//{
//    Account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
//}
//catch (InvalidOperationException e)
//{
//    Console.WriteLine("Exception caught trying to overdraw");
//    Console.WriteLine(e.ToString());
//}

Account.MakeWithdrawal(50, DateTime.Now, "Xbox Game");
Console.WriteLine(Account.Balance);





