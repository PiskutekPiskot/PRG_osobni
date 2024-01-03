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
        public string Currency;
        public int Balance;
        public BankAccount(int acc,string hol, string cur,int bal)
        {
            this.accountNumber = acc;
            this.holderName = hol;
            this.Currency = cur;
            this.Balance = bal;
        }
        public void Deposit(int amount)
        {
            Balance += amount;
            Console.WriteLine(holderName + "'s current balance is: " + Balance);
        }
        public void Withdraw(int amount)
        {
            if (Balance>amount)
            {
                Balance -= amount;
                Console.WriteLine(holderName+"'s current balance is: "+ Balance);
            }
            else
            {
                Console.WriteLine(holderName +" does not have a high enough balance to execute this transaction.");
            }
        }
        public void Transfer(int amount, int account)
        {
           
        }
    }
}

