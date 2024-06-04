using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice0528
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            a += 30;
            Console.WriteLine(a);

            int[] b = { 11, 22, 33 };
            Console.WriteLine(b[1]);

            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
            foreach (int i in b)
            {
                Console.WriteLine(i);
            }

            int c = 100;
            if (c > 0)
            {
                Console.WriteLine("cは正の数");
            }
            else if (c < 0)
            {
                Console.WriteLine("cは負の数");
            }
            else
            {
                Console.WriteLine("cは0");
            }

            switch(c)
            {
                case 1:
                    Console.WriteLine("変数cは1");
                    break;
                case 2:
                    Console.WriteLine("変数cは2");
                    break;
                default:
                    Console.WriteLine("変数は1か2以外");
                    break;
            }

            Random rnd = new Random();
            int d = rnd.Next(1, 7);

            while (true)
            {
                d = rnd.Next(1, 7);
                Console.WriteLine(d);
                if(d == 6)
                {
                    break;
                }

            }
        }
    }
}
