using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    interface IGross
    {
        void Gross_sal();
    }

    interface ISal
    {
        void ISal(double Hra, double Da, double Ta);

        void Dis_sal();
    }

    class Employee : IGross,ISal
    {
        private string name;
        public void Gross_sal()
        {
            Console.WriteLine("It's Gross Salary");
        }

        public void ISal(double hra, double da, double ta)
        {
            Console.WriteLine("HRA: "+hra+" DA: "+da+" TA: "+ta);
        }
        public void Dis_sal()
        {
            Console.WriteLine("It's Display Salary");
        }

        public void Basic_sal()
        {
            Console.WriteLine("It's Basic Salary");
        }
    }
}
