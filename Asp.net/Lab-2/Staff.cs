using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Staff
    {
        string Name;
        string Department;
        string Designation;
        int Experience;
        int Salary;


        public void GetStaffDetails()
        {
            Console.WriteLine("Enter Name:");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Department:");
            Department = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Designation:");
            Designation = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Experience:");
            Experience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Salary:");
            Salary = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayStaffDetails()
        {
            Console.WriteLine("Name Is :" + Name);
            Console.WriteLine("Salary Is:" + Salary);
        }

        public string Design()
        {
            return Designation;
        }

    }
}