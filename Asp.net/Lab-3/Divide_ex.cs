using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    //Write a program to Create a divide by zero exception and handle it.
    internal class Devide_ex
    {
        int num1;
        int num2;
        double ans;
        public Devide_ex(int n1,int n2) {
            num1 = n1;
            num2 = n2;
        }

        public void Devide()
        {
            try{
                ans = num1 / num2;
            }
            catch(DivideByZeroException e) {
                Console.WriteLine("Exception " + e.Message);
            }
            Console.WriteLine("Answer is:" + ans);
        }

    }
}
