﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class BankAccount
{
    private int id;
    private double balance;
    


    public BankAccount()
    {
        this.ID = id;
        this.Balance = balance;
    }
    public int ID { get; set; }
    public double Balance { get; set; }

    public void Deposit(double amount)
    {
        this.balance += amount;
    }

    public void Withdraw(double amount)
    {
        this.balance -= amount;
    }
    public override string ToString()
    {
        return $"Account {this.id}, balance {this.balance}";
    }

}

