using System;
namespace OOP_Practice
{
    class BankAccount //Задание 1
    {
        // Закрытые поля
        private int accountNumber;
        private double balance; //Задание 3
        private string ownerName; //Самостоятельное 1
        // Свойство для номера счета (только для чтения)
        public int AccountNumber
        {
            get { return accountNumber; }
        }
        // Свойство для баланса (только для чтения)
        public double Balance
        {
            get { return balance; }
        }
        // Свойство для имени владельца счета (чтение и запись)
        public string OwnerName
        {
            get { return ownerName; }
            set { ownerName = value; }
        }

        // Конструктор класса

        public BankAccount(int accountNumber, double initialBalance, string ownerName)
        {
            this.accountNumber = accountNumber;
            balance = initialBalance;
            this.ownerName = ownerName;
        }
        // Метод для пополнения счета
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Счет пополнен на {amount}. Текущий баланс: {balance}");
            }
            else
            {
                Console.WriteLine("Невозможно пополнить счет на отрицательную сумму.");
            }
        }
        // Метод для снятия средств
        public void Withdraw(double amount)
        {
            double commission = amount * 0.01;
            double totalAmountToWithdraw = amount + commission; //Самост. 2

            if (totalAmountToWithdraw > balance)
            {
                Console.WriteLine("Ошибка: недостаточно средств на счете.");
            }
            else if (amount > 0)
            {
                balance -= totalAmountToWithdraw;
                Console.WriteLine($"Со счета снято {amount}. Комиссия: {commission}. Текущий баланс: {balance}");
            }
            else
            {
                Console.WriteLine("Невозможно снять отрицательную сумму.");
            }
        }
    }
}
