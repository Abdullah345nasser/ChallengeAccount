using System;

public class Account
{
    public string Name;
    public double balance;

    public Account(string name = "Unnamed Account", double balance = 0.0)
    {
        this.Name = name;
        this.balance = balance;
    }

    public bool Deposit(double amount)
    {
        if (amount < 0)
            return false;
        else
        {
            balance += amount;
            return true;
        }
    }

    public virtual bool Withdraw(double amount)
    {
        if (balance - amount >= 0)
        {
            balance -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }

    public double GetBalance()
    {
        return balance;
    }

}

public class CheckingAccount : Account
{



    public CheckingAccount(string name = "non", double balance = 0.0)
    {

    }

    public override bool Withdraw(double amount)
    {

        return base.Withdraw(amount + 1.50);

    }
}
