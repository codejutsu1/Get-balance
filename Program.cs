// See https://aka.ms/new-console-template for more information
using WEEK4;

BankA bankA = new();
BankB bankB = new();
BankC bankC = new();

Console.WriteLine("Balance in Bank A: $" + bankA.GetBalance());
Console.WriteLine("Balance in Bank B: $" + bankB.GetBalance());
Console.WriteLine("Balance in Bank C: $" + bankC.GetBalance());