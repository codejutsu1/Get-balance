using WEEK4.MainBank;
public class BankB : Bank
{
    private int balance = 150; // Initial balance

    // Implementation of abstract method "getBalance" for BankC
    public override int GetBalance()
    {
        return balance;
    }
}