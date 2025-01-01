using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;

namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Candidate c1 = new Candidate();
            //c1.GetCandidateDetails();
            //c1.DisplayCandidateDetails();

            //Staff[] s1 = new Staff[5];
            //for (int i = 0; i < 5; i++) {
            //    s1[i] = new Staff();    
            //    s1[i].GetStaffDetails();
            //}
            //Console.WriteLine("Hod Designation are:");
            //for (int i = 0;i < 5; i++)
            //{

            //    if (s1[i].Design() == "hod")
            //    {
            //        s1[i].DisplayStaffDetails();
            //    }

            //}

            //Bank_Account account = new Bank_Account();
            //account.GetAccountDetails();
            //account.DisplayAccountDetails();

            //Student s1 = new Student(8732, "sdfhxdcgfj", 543, 346.5, 54);
            //s1.Display();

            //Rectangle rec = new Rectangle(3, 4);
            //Console.WriteLine("Area is: "+rec.Area());

            //Interest intecal = new Interest();
            //intecal.GetAccountDetails();
            //intecal.Interest_Calculate();
            //intecal.Display_Interest();

            //Salary sal = new Salary(10000,234,12);
            //sal.DisplaySalary();

            //Distance dis = new Distance(100, 200);
            //dis.Addition();
            //dis.Display();

            //Table tab = new Table("Laal Chandan", 1400000.2, 11.11, 12.24);
            //tab.DisplayDetails();

            Employee emp = new Employee();
            emp.Gross_sal();
            emp.ISal(8273, 732, 98324);
            emp.Dis_sal();
            emp.Basic_sal();
        }
    }
}
