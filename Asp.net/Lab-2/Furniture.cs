using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Furniture
    {
        protected string material;
        protected double price;

        public Furniture(string material, double price)
        {
            this.material = material;
            this.price = price;
        }
    }

    class Table : Furniture
    {
        double height;
        double surface_area;

        public Table(string material, double price, double height, double surface_area) : base(material, price) 
        {
            this.height = height;
            this.surface_area = surface_area;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Material: " + material + " ,Price: " + price + " ,Height: " + height + " ,Surface-Area: " + surface_area);
        }
    }
}
