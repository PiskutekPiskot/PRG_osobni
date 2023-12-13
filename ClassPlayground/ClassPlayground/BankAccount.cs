using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class BankAccount
    {
        
        public int accountNumber;
        public string holderName;
        public string currency;
        public int balance;
        public BankAccount( string holderName, string currency, int balance)
        {
            Random rnd = new Random();
            this.accountNumber=rnd.Next(100000000,1000000000);
            this.holderName = holderName;
            this.currency = currency;   
            this.balance = balance;
        }
        public void Deposit(int amount,string currency)
        {
            balance += amount;
        }
        public void Withdraw(int amount)
        {
            if (amount < balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Balance is not sufficient for this transaction.");
            }
        }
        public void Transfer(BankAccount user, int amount)
        {
            if (amount < balance)
            {
                balance -= amount;
                user.balance += amount;
            }
            else
            {
                Console.WriteLine("Balance is not sufficient for this transaction.");
            }
        }
        public void AccountInfo()
        {
            Console.WriteLine($"{accountNumber} is {holderName}'s account with {balance} {currency}");
        }

    }
}
