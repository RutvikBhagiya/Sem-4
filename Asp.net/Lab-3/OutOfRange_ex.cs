using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class OutOfRange_ex
    {
        int[] arr = new int[2];
        public void OutBound()
        {
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Enter Num:");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Exception "+e.Message);
            }
        }
    }
}
