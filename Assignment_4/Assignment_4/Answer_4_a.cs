using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Bank
    {
        private string accNo;
        private string customerName;
        private string accountType;
        private char transactionType;
        private decimal amount;
        private decimal balance;

        public Bank(string accountNo, string customerName, string accountType)
        {
            this.accNo = accountNo;
            this.customerName = customerName;
            this.accountType = accountType;
            this.transactionType = '\0'; // Initializes a null value
            this.amount = 0;
            this.balance = 0;
        }

        public void Credit(decimal amount)
        {
            if (amount > 0)
            {
                this.transactionType = 'D';
                this.amount = amount;
                this.balance += amount;
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Debit(decimal amount)
        {
            if (amount > 0 && this.balance >= amount)
            {
                this.transactionType = 'W';
                this.amount = amount;
                this.balance -= amount;
            }
            else
            {
                Console.WriteLine("insufficient balance.");
                Console.ReadLine();
            }
        }

        public void ShowData()
        {
            Console.WriteLine("Account Number: " + this.accNo);
            Console.WriteLine("Customer Name: " + this.customerName);
            Console.WriteLine("Account Type: " + this.accountType);
            Console.WriteLine("Transaction Type: " + this.transactionType);
            Console.WriteLine("Amount: " + this.amount);
            Console.WriteLine("Balance: " + this.balance);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Bank acc = new Bank("1033", "Arun", "Savings");
            acc.Credit(1000);
            acc.ShowData();

            acc.Debit(500);
            acc.ShowData();
        }
    }
}