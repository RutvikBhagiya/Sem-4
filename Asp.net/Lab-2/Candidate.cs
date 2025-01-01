using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Candidate
    {
        int ID;
        string Name;
        int Age;
        double Weight;
        double Height;

        public void GetCandidateDetails()
        {
            Console.WriteLine("Enter Id:");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Age:");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Weight:");
            Weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Height:");
            Height = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayCandidateDetails()
        {
            Console.WriteLine("Id is: " + ID);
            Console.WriteLine("Name is: " + Name);
            Console.WriteLine("Age is: " + Age);
            Console.WriteLine("Weight is: " + Weight);
            Console.WriteLine("Height is: " + Height);
        }
    }
}