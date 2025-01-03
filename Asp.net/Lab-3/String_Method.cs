using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class String_Method
    {
        string demo = " Hello! From My World 9";
        public void Methods()
        {
            Console.WriteLine("String is: " + demo);
            Console.WriteLine("Length: " + demo.Length);
            Console.WriteLine("Upper Case:"+demo.ToUpper());
            Console.WriteLine("Substring from (6,3) is:" + demo.Substring(6, 3));
            Console.WriteLine("Replace  Hello to Hi:-->"+demo.Replace("Hello","Hi"));
            Console.WriteLine("Contains or not:"+demo.Contains("!"));
        }
    }
}
