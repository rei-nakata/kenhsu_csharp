using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace price_class2
{
    public class Chara
    {
        //feild
        protected string name;
        protected int price;
        protected int paid;

        //property
        public string Name
        {
            get { return this.name; }
        }
        public int Price
        {
            get { return this.price; } 
        }

        //constructor
        public Chara(string name)
        {
            this.name = name;
        }

        //method
        public int input()
        {
            Console.WriteLine("{0}さんの支払い済みの金額を入力してください", this.name);
            paid = int.Parse(Console.ReadLine());
            return paid;
        }
        

        public void show(int ave)
        {
            if (this.paid < ave)
            {
                Console.WriteLine("{0}さんは\\{1}支払います", this.name, ave-this.paid);
            }
            else if (this.paid == ave)
            {
                Console.WriteLine("{0}さんは支払いも受け取りもありません", this.name);
            }
            else
            {
                Console.WriteLine("{0}さんは\\{1}受け取ります", this.name, this.paid - ave);
            }
        }
    }
}
