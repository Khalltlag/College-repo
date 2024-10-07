using System;

namespace OOP_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BankAccount myAccount = new BankAccount(123456, 1000, "Владелец счета");
            
            myAccount.Deposit(5000);
            
            myAccount.Withdraw(2000);
            
            myAccount.Withdraw(6000);
            
            Console.WriteLine($"Текущий баланс счета: {myAccount.Balance}");


        }

    }
}
