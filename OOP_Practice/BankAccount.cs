using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    public class BankAccount
    {
        private int accountNumber;
        private double balance;
        public string ownerName { get; set; }

        public int accountNumberPublic
        {
            get { return accountNumber; }
        }

        public double balancePublic
        {
            get { return balance; }
        }

        public BankAccount(int accountNumber, double intialbalance, string OwnerName)
        {
            this.accountNumber = accountNumber;
            balance = intialbalance;
            ownerName = OwnerName;
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited {amount}");
            }
            else
            {
                Console.WriteLine("Cant deposit negative");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Not enough funds");
            }
            else if (amount > 1000) 
            {
                amount -= 10;
                Console.WriteLine($"Комиссия {amount}");
            }
            else
            {
                balance -= amount * 1.01;
                Console.WriteLine($"withdrawn {amount}, {amount * 0.01} comission");
            }
        }
    }
}