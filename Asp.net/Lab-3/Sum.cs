using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal abstract class Sum
    {
        public abstract void SumOfTwo(int num1, int num2);
        public abstract void SumOfThree(int num1, int num2, int num3);
    }
    internal class Calculate : Sum
    {
        public override void SumOfTwo(int num1, int num2)
        {
            
            Console.WriteLine("Sum Of Two is:" + (num1 + num2));
        }

        public override void SumOfThree(int num1, int num2, int num3)
        {
            
            Console.WriteLine("Sum Of Three is:" + (num1 + num2 + num3));
        }
    }
}
