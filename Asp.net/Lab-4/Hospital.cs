using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_4
{
    internal class Hospital
    {
        string Name;
        
        public virtual void HospitalDetails()
        {
            Console.WriteLine("Enter Hospital Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Name: " + Name);
        }
    }

    internal class Apollo:Hospital
    {
        string Name;
        int id;
        public override void HospitalDetails()
        {
            Console.WriteLine("Enter Hospital Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Hospital Id:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: " + Name + " ,id: " + id);
        }
    }

    internal class Wockhardt : Hospital
    {
        string Name;
        int id;
        public override void HospitalDetails()
        {
            Console.WriteLine("Enter Hospital Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Hospital Id:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: " + Name + " ,id: " + id);
        }
    }

    internal class Gokul_Superspeciality : Hospital
    {
        string Name;
        int id;
        public override void HospitalDetails()
        {
            Console.WriteLine("Enter Hospital Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Hospital Id:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: " + Name + " ,id: " + id);
        }
    }
}
