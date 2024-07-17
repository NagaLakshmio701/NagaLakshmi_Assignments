using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment2
{
    public class Accounts
    {
        // Data members
        private int accountNumber;
        private string customerName;
        private string accountType;
        private char transactionType; // 'D' for Deposit, 'W' for Withdrawal
        private double amount;
        private double balance;

         
       public void Accept(int accountNumber, string customerName, string accountType, char transactionType, double amount)
       
        {
            this.accountNumber = accountNumber;
            this.customerName = customerName;
            this.accountType = accountType;
            this.transactionType = transactionType;
            this.amount = amount;

            // Perform credit or debit based on transaction type
            if (transactionType == 'D')
            {
                Credit(amount);
            }
            else if (transactionType == 'W')
            {
                Debit(amount);
            }
            else
            {
                Console.WriteLine("Invalid transaction type.");
            }
        }

        // Method to perform credit (deposit)
        private void Credit(double amount)
        {
            this.balance += amount;
        }

        // Method to perform debit (withdrawal)
        private void Debit(double amount)
        {
            if (amount <= balance)
            {
                this.balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        // Method to display account information
        public void ShowData()
        {
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Account Type: {accountType}");
            Console.WriteLine($"Transaction Type: {transactionType}");
            Console.WriteLine($"Amount: {amount}");
            Console.WriteLine($"Balance: {balance}");
        }
    }

    class Program1
    {
        static void Main()
        {
            // Create an instance of Accounts
            Accounts myAccount = new Accounts();

            // Accept account details and perform transactions
            myAccount.Accept(123456, "John Doe", "Savings", 'D', 1000); // Deposit
            myAccount.ShowData();

            Console.WriteLine(); // Separate deposit and withdrawal example

            myAccount.Accept(123457, "Jane Smith", "Checking", 'W', 500); // Withdrawal
            myAccount.ShowData();
        }
    }


}
