using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Account_Details
    {
        protected string AccountHolder;
        protected double PrincipleAmount;
        protected double InterestRate;
        protected int TimePeriod;
        public void GetAccountDetails()
        {
            Console.WriteLine("Enter Account Holder Name:");
            AccountHolder = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Principle Amount:");
            PrincipleAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Interest Rate:");
            InterestRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Time Period:");
            TimePeriod = Convert.ToInt32(Console.ReadLine());
        }
    }
    class Interest : Account_Details
    {
        private double interest;
        public void Interest_Calculate()
        {
            interest = (PrincipleAmount * InterestRate * TimePeriod) / 100;
        }

        public void Display_Interest()
        {
            Console.WriteLine("AccountHolder:" + AccountHolder);
            Console.WriteLine("PrincipleAmount:" + PrincipleAmount);
            Console.WriteLine("InterestRate:" + InterestRate);
            Console.WriteLine("TimePeriod:" + TimePeriod);
            Console.WriteLine("Interest is:" + interest);
        }
    }
}
