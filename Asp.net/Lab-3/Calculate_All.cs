using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal interface Calculate_All
    {
        void Addition(int num1,int num2);
        void Subtraction(int num1,int num2); 
    }

    public class Result : Calculate_All
    {
        public void Addition(int num1,int num2)
        {
            Console.WriteLine("Addition is:" + (num1 + num2));
        }

        public void Subtraction(int num1,int num2)
        {
            Console.WriteLine("Substarction is:" + (num1 - num2));
        }
    }
}
