using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Rectangle
    {
        int len, wid;
        public Rectangle(int l,int w)
        {
            this.len = l;   
            this.wid = w;
        }

        public int Area()
        {
            return len * wid;
        }
    }
}
