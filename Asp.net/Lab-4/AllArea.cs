using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class AllArea
    {
        public double CalArea(int l)
        {
            return l * l;
        }

        public double CalArea(int l, int b)
        {
            return l * b;
        }

        public double CalArea(double r)
        {
            return (3.14*r*r);
        }
    }
}
