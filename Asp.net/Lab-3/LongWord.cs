using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class LongWord
    {
        string word;
        public LongWord(string word)
        {
            this.word = word;
        }

        public void checkWord()
        {
            char[] myword = word.ToCharArray();
            int temp = 0;
            int index = 0;
            int maxlen = 0;
            for (int i = 0; i < myword.Length; i++)
            {
                
                if (myword[i] == ' ' || i == myword.Length-1) 
                {
                    
                    if (temp > maxlen)
                    {
                        index = i;
                        maxlen = temp;
                    }
                    temp = 0;
                }
                temp++;
            }
            Console.WriteLine("Longest Word Lenght is:" + maxlen);
            char[] newchar = new char[maxlen];
            for(int i = (index - maxlen)+1; i <= index; i++)
            {
                newchar[i- ((index - maxlen)+1)] = myword[i];
            }
            string mystr = new string(newchar);
            Console.WriteLine(mystr);
        }
    }
}
