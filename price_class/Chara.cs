using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace price_class
{
    public class Chara
    {
        //global ave;

        //field
        protected string name;
        protected int paid_price;

        //property
        public string Namae
        {
            get { return this.name; }
        }
        public int Paid_price
        {
            get { return this.paid_price; }
        }

        //constructor
        public Chara(string name, int price) 
        {
            this.name = name;
            this.paid_price = price;
        }

        //method
        //public void show()
        //{
        //    if (this.paid_price == ave)
        //    {
        //        Console.WriteLine(0);
        //    }
        //    else if (this.paid_price < ave)
        //    {
        //        Console.WriteLine("{0}に\\{1}払います", ave - this.paid_price);
        //    }
        //    else
        //    {
        //        Console.WriteLine("{0}から\\{1}もらいます", this.paid_price - ave);
        //    }
        //}
        
    }
}
