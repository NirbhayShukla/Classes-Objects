using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class BankAccount
    {
        string name, accountType;
        int acNumber;
        double balance;

        public BankAccount(string name, string accountType, int acNumber, double balance)
        {
            this.name = name;
            this.accountType = accountType;
            this.acNumber = acNumber;
            this.balance = balance;
        }

        public void deposit(double amount)
        {
            balance += amount;
        }

        public void withdraw(double amount)
        {
            if (balance >= amount) balance -= amount;
        }

        public void display()
        {
            Console.WriteLine($"Name : {name} , Balance : {balance}");
        }
    }
}
