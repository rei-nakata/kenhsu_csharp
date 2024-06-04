using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace price_class2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("割り勘アプリ");

            //初期化
            var sum = 0;
            var ave = 0;

            //呼び出し
            var sato = new Chara("佐藤");
            sum += sato.input();

            var suzuki = new Chara("鈴木");
            sum += suzuki.input();

            var tanaka = new Chara("田中");
            sum += tanaka.input();

            //出力
            ave = sum / 3;
            sato.show(ave);
            suzuki.show(ave);
            tanaka.show(ave);

        }
    }
}
