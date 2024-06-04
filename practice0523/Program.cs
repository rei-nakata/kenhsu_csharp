using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice0523
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            //ConsoleAppl.Readkey();
            Console.Write("‰üs‚È‚¢");
            Console.Write("‰üs‚È‚¢");

            int a = 3;//•Ï”‚ÌéŒ¾‚Æ‘ã“ü
            Console.WriteLine(a);//•Ï”‚ÌQÆ

            int num = 123;
            Console.WriteLine(num);

            string name = "nakata";
            Console.WriteLine(name);
            Console.WriteLine("My name is" + name + ".");
            Console.WriteLine("My name is {0}. ",name);

            const int NUMBER = 100;
            Console.WriteLine(NUMBER);

            double d = 1.24;
            int b = (int)d;
            Console.WriteLine(b);

            string s = "12345";
            int i = int.Parse(s);
            Console.WriteLine(i+100);

            int n = 800;
            string numString = n.ToString();
            Console.WriteLine(numString+800);

            int intNum = int.Parse(numString);
            Console.WriteLine(intNum);
        }
    }
}
