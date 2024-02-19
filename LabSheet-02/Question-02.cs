//2.	Develop a console program that models a simple bank account. Create a class named ‘BankAccount’ with properties AccountNumber and Balance. Implement a method ‘Deposit’ that allows the user to deposit money into the account. Instantiate an object, perform a deposit, and display the updated balance.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BankAccount
{
    public string AccountNumber { get; set; }
    public double Balance { get; private set; }

    public BankAccount (string accountNumber)
    {
        AccountNumber = accountNumber;
        Balance = 0;
    }

    public void Deposit (double amount)
    {
        Balance += amount;
    }

}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount("10348 8756 74635");

        // deposit money into the account
        double depositAmount = 1000.00;
        account.Deposit(depositAmount);

        // Display the updated balance
        Console.WriteLine("Account Number: " + account.AccountNumber);
        Console.WriteLine("Balance after deposit: " + account.Balance);
    }
}