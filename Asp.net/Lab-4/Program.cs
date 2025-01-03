using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Addition ad = new Addition();
            //Console.WriteLine(ad.addition(2, 5));
            //Console.WriteLine(ad.addition(2.5, 5.6));

            //Area ar = new Area();
            //Console.WriteLine(ar.FindArea(3));
            //Console.WriteLine(ar.FindArea(3,6));

            //RBI interest = new RBI();
            //Console.WriteLine(interest.calculateInterest(10, 10, 10));

            //Hospital hr = new Apollo();
            //hr.HospitalDetails();

            //AllArea area = new AllArea();
            //Console.WriteLine(area.CalArea(1.2));

            BankAccount ac = new BankAccount("Rutvik",927923);
            ac.Withdraw(8276,"paisa udadva na che");
            ac.DisplayAccount();
        }
    }
}
