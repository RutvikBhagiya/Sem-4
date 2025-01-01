using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Salary
    {
        double Basic;
        double Ta;
        double Da;
        double Hra;

        public Salary(double basic, double ta, double da=10, double hra=15)
        {
            Basic = basic;
            Ta = ta;
            Da = da;
            Hra = hra;
        }

        public double Calculate_Salary()
        {
            double Daamount = (Basic * Da) / 100;
            double Hraamount = (Basic * Hra) / 100;
            return (Basic + Ta + Daamount +  Hraamount);
        }

        public void DisplaySalary()
        {
            Console.WriteLine("Basic Salary is:"+ Basic);
            Console.WriteLine("TA is:"+ Ta);
            Console.WriteLine("DA is:"+ Da);
            Console.WriteLine("HRA is:"+Hra);
            Console.WriteLine("\nTotal Salary is:"+Calculate_Salary());
        }
    }
}
