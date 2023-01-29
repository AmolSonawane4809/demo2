namespace Banking;
using utility;


public class Account{
    public double balance{get;set;}
    
   public event SimpleOperation underbalance;
    public event SimpleOperation overbalance;

public void Deposit(Double amount)
{
    this.balance+=amount;
if(this.balance>=250000)
{
overbalance(this);
}

}

public void Withdraw(Double amount)
{
this.balance-=amount;
if(this.balance<=5000)
{
underbalance(this);
}

}

}