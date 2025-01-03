using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Replace_Char
    {
        string mystr = "";
        string swapstr = "";
        public Replace_Char(string str) 
        {
            mystr = str;
        }

        public string Case_Checking()
        {
            char[] mychar = mystr.ToCharArray();
            for(int i = 0; i < mychar.Length; i++)
            {
                if (char.IsUpper(mychar[i]))
                {
                    mychar[i] = char.ToLower(mychar[i]);
                }
                else
                {
                    mychar[i] = char.ToUpper(mychar[i]);
                }
            }
            swapstr = new string(mychar);
            return swapstr;
        }
    }
}
