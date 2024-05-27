using WEEK4.MainBank;
public class BankC : Bank
{
    private int balance = 200; // Initial balance

    // Implementation of abstract method "getBalance" for BankC
    public override int GetBalance()
    {
        return balance;
    }
}