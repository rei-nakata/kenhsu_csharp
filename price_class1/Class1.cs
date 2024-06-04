using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace price_class1
{
    public class Input
    {
        //field
        protected int num;
        protected string name;

        //property
        public int Num// { get; }
        {
            get { return this.num; }
        }
        public string Name
        {
            get { return this.name; } 
        }

        //constructor
        public Input(string name)
        {
            this.name = name;
        }

        //method
        public int check(int num, string name)
        {
            while (true)
            {
                Console.WriteLine("{0}を教えてください", name);
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("不正な入力値です");
                    continue;
                }
            }
            return num;
        }
    }
}