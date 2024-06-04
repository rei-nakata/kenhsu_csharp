using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace price_noclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("割り勘アプリ");
            
            //初期化
            var num = 0;
            var total_price = 0;

            //コンソール入力
            while (true)
            {
                Console.WriteLine("人数を教えてください");
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

            while (true)
            {
                Console.WriteLine("合計金額を教えてください");
                total_price = int.Parse(Console.ReadLine());

                if (total_price > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("不正な入力値です");
                    continue;
                }
            }

            //コンソール出力
            var fee = total_price / num;
            Console.WriteLine("一人当たりの金額は\\{0}です。", fee);
        }
    }
}
