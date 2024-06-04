using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_0523
{
    internal class Program
    {
        static void Main(string[] args)
        {

　　　　Console.WriteLine("Hello World");
        //ConsoleAppl.Readkey();
        Console.Write("改行ない");
        Console.Write("改行ない");

        int a = 3;//変数の宣言と代入
        Console.WriteLine(a);//変数の参照

        int num = 123;
        Console.WriteLine(num);

        string name = "nakata";
        Console.WriteLine(name);
        Console.WriteLine("My name is" + name + ".");
        Console.WriteLine("My name is {0}. ", name);

        const int NUMBER = 100;
        Console.WriteLine(NUMBER);

        double d = 1.24;
        int b = (int)d;
        Console.WriteLine(b);

        string s = "12345";
        int i = int.Parse(s);
        Console.WriteLine(i + 100);

        int n = 800;
        string numString = n.ToString();
        Console.WriteLine(numString + 800);

        int intNum = int.Parse(numString);
        Console.WriteLine(intNum);
        }
    }
}
