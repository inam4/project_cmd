﻿using System;
using System.Collections.Generic;

interface IBankAccount  //the class that inherits from interface class must have methods mentioned.
{
    void Deposit(float amount);
    void Withdraw(float amount);

}
public abstract class BankAccount : IBankAccount
{
    protected string Name;
    protected int AccountNumber;
    protected float Balance;
    public string Account_type;
    public BankAccount(string name,int acc_number,float balance,string account_type)
    {
        Name = name;
        AccountNumber = acc_number;
        Balance = balance;
        Account_type = account_type;
    }

    public virtual void Deposit(float Amount_Add)
    {
        Balance = Balance + Amount_Add;
        Console.WriteLine($"{Name}'s Account with ID {AccountNumber} credited with amount {Amount_Add} ");
        Console.WriteLine($"New Balance is PKR{Balance}");
    }
    
    public virtual void Withdraw(float DEL)
    {
        Balance = Balance - DEL;
        Console.WriteLine($"{Name}'s Account with ID {AccountNumber} decredited with amount {DEL} ");
        Console.WriteLine($"New Balance is PKR{Balance}");
    }

    public abstract void DisplayAccountInfo();


}

public class SavingsAcccount : BankAccount
{
    public SavingsAcccount(string name, int acc_number, float balance) : base(name, acc_number, balance, "Savings Account")
    {

    }

    public override void Deposit(float Amount_Add)
    {
        float InterestRate = 12;
        Balance = Balance + Amount_Add;
        Balance = ((InterestRate / 100) * (Balance)) + Balance;
        Console.WriteLine($"{Name}'s Account with ID {AccountNumber} credited with amount {Amount_Add} and Interest Rate {InterestRate}%");
        Console.WriteLine($"New Balance is PKR{Balance}");
    }
    public override void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Bank Account Type: {Account_type}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Balance: {Balance}");
    }

    

}

public class CheckingAcccount : BankAccount
{
    public float InterestRate;
    public CheckingAcccount(string name, int acc_number, float balance) : base(name, acc_number, balance, "Checking Account")
    {

    }

    public override void Withdraw(float DEL)
    {
        if (Balance == DEL)
        {
            Console.WriteLine("Amount not added. Current balance is equal to Withdrawal");
        }
        else
        {
            Balance = Balance - DEL;
            Console.WriteLine($"{Name}'s Account with ID {AccountNumber} decredited with amount {DEL} ");
            Console.WriteLine($"New Balance is PKR{Balance}");
        }
    }
    public override void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Bank Account Type: {Account_type}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Balance: {Balance}");
    }

   
}

public class Bank
{
    public List<BankAccount> Customer_Account;
    public Bank()
    {
        Customer_Account = new List<BankAccount>();
    }

    public void AddAccount(BankAccount bank_account)
    {
        Customer_Account.Add(bank_account);
        bank_account.DisplayAccountInfo();
    }

    public void DepositToAccount(BankAccount bank_account, float Amount_Add)
    {
        bank_account.Deposit(Amount_Add);

    }

    public void WithdrawFromAccount(BankAccount bank_account, float Amount_DEL)
    {

        bank_account.Withdraw(Amount_DEL);

    }
    public void CheckAccount(BankAccount bank_account)
    {

        bank_account.DisplayAccountInfo();

    }
}

class Program
{
    static void Main(string[] args)

    {
        Bank bank = new Bank();
     
        SavingsAcccount s_acc = new SavingsAcccount("Zain", 1, 98000);
        CheckingAcccount c_acc = new CheckingAcccount("Osama", 2, 100000);
        BankAccount[] bank_accounts = {s_acc,c_acc };

        Console.WriteLine("---------------------------------Saving Account-------------------------------");
        bank.AddAccount(s_acc);
        Console.WriteLine();
        bank.DepositToAccount(s_acc, 2000);
        Console.WriteLine();
        bank.WithdrawFromAccount(s_acc, 5000);
        Console.WriteLine();

        Console.WriteLine("---------------------------------Checking Account-------------------------------");
        bank.AddAccount(c_acc);
        Console.WriteLine();
        bank.DepositToAccount(c_acc, 2000);
        Console.WriteLine();
        bank.WithdrawFromAccount(c_acc, 5000);
        Console.WriteLine();

        foreach (BankAccount account in bank_accounts)
        {
            account.DisplayAccountInfo();
        }


//Console.WriteLine("---------------------------------Saving Account-------------------------------");
//        bank.AddAccount(s_acc);
//        Console.WriteLine();
//        bank.DepositToAccount(s_acc, 2000);
//        Console.WriteLine();
//        bank.WithdrawFromAccount(s_acc, 5000);
//        Console.WriteLine();
//        bank.CheckAccount(s_acc);

        //Console.WriteLine("---------------------------------Checking Account-------------------------------");
        //bank.AddAccount(c_acc);
        //Console.WriteLine();
        //bank.DepositToAccount(c_acc, 2000);
        //Console.WriteLine();
        //bank.WithdrawFromAccount(c_acc, 5000);
        //Console.WriteLine();
        //bank.CheckAccount(c_acc);

        //Console.WriteLine(s_acc.Account_type);
        

    }
}


