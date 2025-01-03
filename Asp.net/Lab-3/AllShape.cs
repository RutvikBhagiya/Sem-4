using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal interface Shape
    {
        void Circle();
        void Triangle();
        void Square();
    }
        public class Calculate_Shape : Shape
        {
            public void Circle()
            {
                Console.WriteLine("Enter Radius:");
                double r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Area of Circle is:" + (3.14 * r * r));
            }

            public void Triangle()
            {
                Console.WriteLine("Enter Base:");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Height:");
                double h = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Area of Triangle is:" + (0.5 * b * h));
            }

            public void Square()
            {
                Console.WriteLine("Enter length:");
                double l = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Area of Square is:" + (l * l));
            }
        }
}
