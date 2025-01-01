using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Distance
    {
        double dist1;
        double dist2;
        double dist3;
        public Distance(double d1,double d2) 
        {
            dist1 = d1;
            dist2 = d2; 
        }

        public void Addition()
        {
            dist3 = dist1+dist2;
           
        }

        public void Display()
        {
            Console.WriteLine("Addition is:" + dist3);
        }


    }
}
