using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace price_class1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("割り勘アプリ");

            var num = new Input("人数");
            var people = num.check(num.Num, num.Name);

            var price = new Input("合計金額");
            var pay = price.check(price.Num, price.Name);

            var fee = pay / people;
            Console.WriteLine("一人当たりの金額は\\{0}です。", fee);
        }
    }
}
