using WEEK4.MainBank;
public class BankA : Bank
{
    private int balance = 100; // Initial balance

    // Implementation of abstract method "getBalance" for BankC
    public override int GetBalance()
    {
        return balance;
    }
}