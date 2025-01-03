using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Even
    {
        public void CheckNum()
        {
            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 != 0)
            {
                throw new Exception("Number is Not Even");
            }
        }
    }
}
