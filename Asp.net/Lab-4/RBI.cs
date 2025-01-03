using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class RBI
    {
        public virtual double calculateInterest(double p,double r,double n)
        {
            return ((p*r*n)/100);
        }
    }

    internal class HDFC : RBI
    {
        public override double calculateInterest(double p, double r, double n)
        {
            return ((p * r * n) / 100);
        }
    } 

    internal class SBI : RBI
    {
        public override double calculateInterest(double p, double r, double n)
        {
            return ((p * r * n) / 100);
        }
    }

    internal class ICICI : RBI
    {
        public override double calculateInterest(double p, double r, double n)
        {
            return ((p * r * n) / 100);
        }
    }
}
