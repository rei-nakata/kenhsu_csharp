using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_0530_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get datetime
            DateTime t = DateTime.Now;
            Console.WriteLine(t);
            DateTime time = new DateTime(2018,12,22);
            Console.WriteLine(time);
            string date = t.ToString("yy/MM/dd");
            Console.WriteLine(date);
            TimeSpan ts = t - time;
            Console.WriteLine(ts);
            Console.WriteLine(ts.Days);


            string name = @"C:/Users/Owner/Desktop/sample.txt";
            using (StreamWriter sw = new StreamWriter(name, true, Encoding.UTF8))
            {
                sw.WriteLine("Apple");  // 改行あり
                sw.Write("Banana");     // 改行無し
                sw.WriteLine("Orange"); // 改行あり
            }

            using (StreamReader sr = new StreamReader(@"C:/Users/Owner/Desktop/sample.txt"))
            {
                string text = sr.ReadToEnd();//最後まで読め
                Console.WriteLine(text);
            }

        }
    }
}
