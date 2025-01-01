using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{
    internal class Bank_Account
    {
        int Account_No;
        string Email;
        string User_Name;
        string Account_Type;
        int Account_Balance;


        public void GetAccountDetails()
        {
            Console.WriteLine("Enter Account_No:");
            Account_No = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email:");
            Email = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter User_Name:");
            User_Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Account_Type:");
            Account_Type = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Account_Balance:");
            Account_Balance = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("Your Account_No is:" + Account_No);
            Console.WriteLine("Your Email is:" + Email);
            Console.WriteLine("Your User_Name is:" + User_Name);
            Console.WriteLine("Your Account_Type is:" + Account_Type);
            Console.WriteLine("Your Account_Balance is:" + Account_Balance);
        }
    }
}