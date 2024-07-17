namespace BankEncapsulation;

public class BankAccount
{
    private double Balance { get; set; } = 0;

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public double GetBalance()
    {
        return Balance;
    }
}