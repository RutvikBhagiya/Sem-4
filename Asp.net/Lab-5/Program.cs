using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array-List
            //ArrayList myArr = new ArrayList();

            //myArr.Add("Rutvik");
            //myArr.Add("Pambhar");
            //myArr.Add("Yash");
            //myArr.Add("Smit");
            //myArr.Add("Pambhar");
            //myArr.Add("Yash");
            //myArr.Add("Smit");
            //myArr.Add("Pambhar");
            //myArr.Add("Yash");
            //foreach (object obj in myArr) { 
            //    Console.WriteLine(obj);
            //}
            //RemoveAt()
            //myArr.RemoveAt(1);
            //foreach (object obj in myArr)
            //{
            //    Console.WriteLine(obj);
            //}

            //RemoveRange(index,count)
            //myArr.RemoveRange(3, 5);
            //foreach (object obj in myArr)
            //{
            //    Console.WriteLine(obj);
            //}

            //Clear
            //myArr.Clear();
            //foreach (object obj in myArr)
            //{
            //    Console.WriteLine(obj);
            //}

            //--------------------------------------------------------------------------

            //List<string> li = new List<string>();

            //Add
            //li.Add("Rutvik");
            //li.Add("Smit");
            //li.Add("Yash");
            //li.Add("Pambhar");
            //li.Add("Rutvik");
            //li.Add("Smit");
            //li.Add("Yash");

            //foreach (object obj in li)
            //{
            //    Console.WriteLine(obj);
            //}

            //Remove()
            //li.Remove("Yash");
            //foreach (object obj in li)
            //{
            //    Console.WriteLine(obj);
            //}

            //RemoveRange()
            //li.RemoveRange(2, 3);
            //foreach (object obj in li)
            //{
            //    Console.WriteLine(obj);
            //}

            //Clear()
            //li.Clear();
            //foreach (object obj in li)
            //{
            //    Console.WriteLine(obj);
            //}

            //---------------------------------------------------------------------------

            //Stack<int> stk = new Stack<int>();
            //Push()
            //stk.Push(1);
            //stk.Push(2);
            //stk.Push(3);
            //stk.Push(4);
            //stk.Push(5);

            //Pop()
            //stk.Pop();

            //Peek()
            //Console.WriteLine(stk.Peek());

            //Contains()
            //Console.WriteLine(stk.Contains(5));

            //Clear()
            //stk.Clear();
            //foreach (int i in stk) 
            //{
            //    Console.WriteLine(i);
            //}

            //------------------------------------------------------------------------

            //Queue<int> qu = new Queue<int>();
            //Enqueue()
            //qu.Enqueue(1);
            //qu.Enqueue(2);
            //qu.Enqueue(3);
            //qu.Enqueue(4);
            //qu.Enqueue(5);

            //Dequeue()
            //qu.Dequeue();


            //Peek()
            //Console.WriteLine(qu.Peek());

            //Contains()
            //Console.WriteLine(qu.Contains(3));

            //Clear()
            //qu.Clear();
            //foreach (int i in qu)
            //{
            //    Console.WriteLine(i);
            //}

            //----------------------------------------------------------------------

            //Dictionary<string, string> dic = new Dictionary<string, string>();
            //Add
            //dic.Add("1", "Rutvik");
            //dic.Add("2", "Smit");
            //dic.Add("3", "Yash");
            //dic.Add("4", "Pambhar");
            //dic.Add("5", "Merja");
            //dic.Add("6", "Ranipa");
            //dic.Add("7", "Meet");

            //Remove
            //dic.Remove("4");


            //ContainsKey
            //Console.WriteLine(dic.ContainsKey("4"));

            //ContainsValue
            //Console.WriteLine(dic.ContainsValue("Rutvik"));

            //Clear
            //dic.Clear();
            //foreach (KeyValuePair<string, string> ele in dic)
            //{
            //    Console.WriteLine(ele.Key + " " + ele.Value);
            //}

            //------------------------------------------------------------------------

            Hashtable hash = new Hashtable();
            //Add 
            hash.Add(1, "Rutvik");
            hash.Add(2, "Smit");
            hash.Add(3,"Yash");
            hash.Add(4, "Meet");
            hash.Add(5, "Patel");

            //Remove
            hash.Remove(5);
            
            //ContainsKey
            Console.WriteLine(hash.ContainsKey(3));

            //ContainsValue
            Console.WriteLine(hash.ContainsValue("Patel"));

            //Clear
            hash.Clear();
            foreach (DictionaryEntry ele in hash)
            {
                Console.WriteLine(ele.Key + " " + ele.Value);
            }
        }
    }
}
