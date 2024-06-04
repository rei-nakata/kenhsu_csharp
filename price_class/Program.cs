using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace price_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("割り勘アプリ");

            //初期値
            var fee = new Dictionary<string, int>();
            var name = "";
            var price = 0;
            //var n = 0;
            //var ave = 0;

            //コンソール入力
            Console.WriteLine("人数を教えてください");
            var num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                var n = i;
                Console.WriteLine("名前を教えてください");
                name = Console.ReadLine();

                Console.WriteLine("支払った金額を教えてください");
                price = int.Parse(Console.ReadLine());

                var n = new Chara(name, price);
            }
            //計算
            //var sum = sato.Paid_price + nakata.Paid_price;
            //var ave = sum / num;

            //コンソール出力
            //for (int k = 0; k < num; k++)
            //{
            //    sato.show();
            //}

        }
    }
}
