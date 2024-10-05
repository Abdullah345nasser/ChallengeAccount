using System;



public class SavingsAccount : Account
{
    public double IntRate { get; set; }

    public SavingsAccount(string name = "non", double intRate = 0, double balance = 0.0)
        : base(name, balance)
    {
        IntRate = intRate;
    }
    public override bool Withdraw(double amount)
    {
        return base.Withdraw(amount + IntRate);
    }

}


public class TrustAccount : SavingsAccount
{
    private int numWithdrawal = 0;
    private int dateN = DateTime.Now.Year;

    public TrustAccount(string Name = "non", double intRate = 0, double balance = 0.0) :
        base(Name, balance)
    {


    }

    public override bool Withdraw(double amount)
    {

        int currentYear = DateTime.Now.Year;

        if (currentYear > dateN)
        {

            numWithdrawal = 0;
            dateN = currentYear;

        }
        double balance = GetBalance();
        const int bonus = 50;
        if (amount < (.2 * balance) && numWithdrawal < 3)
        {
            numWithdrawal++;
            if (amount >= 5000)

            {
                Deposit(bonus);

            }

            return base.Withdraw(amount);

        }
        return false;
    }
}

