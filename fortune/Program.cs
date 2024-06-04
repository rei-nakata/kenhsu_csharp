using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fortune
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            /*
            switch (result)
            {
                case 6:
                    Console.WriteLine("あたり");
                    break;
                default:
                    Console.WriteLine("はずれ");
                    break;
            }
            */
            while (true)
            {
                int result = rnd.Next(1, 7);
                Console.WriteLine(result);
                if (result == 6)
                {
                    Console.WriteLine("当たり");
                    break;
                }
                else
                {
                    Console.WriteLine("外れ");
                }

            }
            //Console.ReadKey();


            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    break;
                }
                Console.WriteLine(i);
                
            }
        }
    }
}
