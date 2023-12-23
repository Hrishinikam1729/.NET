using TaxO;
using NotificationO;
namespace Banking;


public class Account
{

    public event NotificationOperation underBalance;
    public event TaxOperation overBalance;

    public float balance { get; set; }

    public void deposit(float amount)
    {
        this.balance += amount;
        Console.WriteLine("Amount " + amount + " has been credited to your Bank Account your balance is " + this.balance);
        if (this.balance >= 200000)
        {
            overBalance(10000);
        }

    }

    public void withdraw(float amount)
    {
        this.balance -= amount;
        Console.WriteLine("Amount " + amount + " has been debited from your Bank Account your balance is " + this.balance);
        if (this.balance <= 10000)
        {
            underBalance("Dear Customer", " Your account is underBalance please credit ");
        }
    }

    public Account()
    {
        this.balance = 5000;
    }

    public Account(float balance)
    {
        this.balance = balance;
    }
}