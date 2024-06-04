using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_0530
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array
            int[] a = { 11, 22, 33 };
            Console.WriteLine(a[1]);

            //list
            List<int> b = new List<int> {11, 22, 33};
            Console.WriteLine(b[0]);
            //add, delete, change
            b.Add(44);
            b[0] = 100;
            b.Remove(100);
            b.RemoveAt(1);
            b.Insert(1, 1000);
            for (int i = 0; i < b.Count; i++)
            {
                Console.WriteLine(b[i]);
            }
            foreach (int value in b)
            { 
                Console.WriteLine(value);
            }

            //HashSet
            HashSet<int> c = new HashSet<int> { 100,200,300};
            c.Add(100);
            foreach (int value in c)
            {
                Console.WriteLine(value);
            }
            HashSet<int> d = new HashSet<int> { 200, 300, 400 };
            c.UnionWith(d);
            foreach (int value in c)
            { 
                Console.WriteLine(value); 
            }
            d.UnionWith(c);
            foreach(int value in d)
            { 
                Console.WriteLine(value); 
            }
            HashSet<int> e = new HashSet<int> (d);
            foreach (int value in e)
            {
                Console.WriteLine(value);
            }

            //dictionary
            Dictionary<string, string> capital = new Dictionary<string, string> 
            {
                {"Japan","Tokyo" },
                {"England","Rondon" },
                {"France", "Pari" }
            };
            capital["USA"] = "D.C";
            foreach (string value in capital.Values)
            {
                Console.WriteLine(value); 
            }
            foreach(string key in capital.Keys)
            {
                Console.WriteLine(key); 
            }
            foreach(KeyValuePair<string,string> item in capital)
            {
                Console.WriteLine("Country is {0}, capital is {1}.", item.Key, item.Value);
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            //array
            int[] aa = new int[] { 1, 2, 3, 4 };
            
            //list
            List<int> bb = new List<int> { 1,2,3,4 };
            
            //dictionary
            Dictionary<int, int> cc = new Dictionary<int, int>
            {
                {11,22 },
                {12,23},
                {13,24}
            };
            
            //hashset
            HashSet<int> dd = new HashSet<int> { 1, 2, 3, 4 };
            HashSet<int> ee = new HashSet<int> { 3,4,5, 6 };

            //remove bb=2,3 all ok
            bb.Remove(4);
            bb.RemoveAt(0);
            //cc.Remove(11, 22);
            cc.Remove(11);
            dd.Remove(4);

            //insert dict and hashset no!
            bb.Insert(0, 100);
            
            //add all ok
            bb.Add(5);
            cc.Add(14,25);
            dd.Add(6);

            //clear all ok
            cc.Clear();

            //intersect hashset only
            dd.IntersectWith(ee);

            //unionwith hashset only
            dd.UnionWith(ee);


            //roop
            foreach (var value in aa)
            {
                Console.WriteLine(value);
            }
            foreach (var value in bb)
            {
                Console.WriteLine(value);
            }
            foreach (KeyValuePair<int,int> item in cc)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
            foreach (var value in dd)
            {
                Console.WriteLine(value);
            }

            try
            {
                int[] sample = { 100, 200, 300 };
                Console.WriteLine(sample[3]);
            }
            catch (Exception error)
            {
                Console.WriteLine("error occured.{0}",error.Message);
                Console.WriteLine(error.ToString());
            }
            finally
            {
                Console.WriteLine("fnish");
            }
            


        }
    }
}
