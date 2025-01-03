using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class BankAccount
    {
        string AcHolderName;
        double Balance;
        public BankAccount(string Name,double bal) 
        {
            AcHolderName = Name;
            Balance = bal;
        }

        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Not Less Than 0 Amount Can be Deposited");
                return;
            }
            Balance = Balance + amount;
            Console.WriteLine("Balance Deposited");
        }

        public void Deposit(double amount,string checkNum)
        {
            if (string.IsNullOrWhiteSpace(checkNum))
            {
                Console.WriteLine("Invalid Check Number");
                return;
            }
            Balance = Balance + amount;
            Console.WriteLine("Balance Deposited");
        }

        public void Withdraw(double amount) 
        {
            if (amount < 0) 
            {
                Console.WriteLine("Amount coudn't be less than 0");
                return;
            } 
            Balance = Balance - amount;
            Console.WriteLine("Balance Withdrawer Successfully");
        }

        public void Withdraw(double amount,string reason) 
        {
            if (amount < 0)
            {
                Console.WriteLine("Amount coudn't be less than 0");
                return;
            }
            Balance = Balance - amount;
            Console.WriteLine($"Balance Withdrawed Successfully by reason of {reason}");
        }

        public void DisplayAccount()
        {
            Console.WriteLine($"Holder Name:{AcHolderName}");
            Console.WriteLine($"Balace is:{Balance}");
        }
    }
}
