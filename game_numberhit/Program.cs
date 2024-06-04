using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_numberhit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数当てゲーム");
            var m_number = 0;

            Random rnd = new Random();
            var c_number = rnd.Next(1, 1000);


            while (true)
            {
                Console.WriteLine("1～999までの数字を入力してください");
                m_number = int.Parse(Console.ReadLine());

                if (m_number < 0 || m_number >= 1000)
                {
                    Console.WriteLine("不正な入力値です。");
                    continue;
                }

                if (m_number > c_number)
                {
                    Console.WriteLine("{0}よりも小さい数字です。", m_number);
                    continue;
                }
                else if (m_number < c_number)
                {
                    Console.WriteLine("{0}よりも大きい数字です。", m_number);
                    continue;
                }
                else
                {
                    Console.WriteLine("大当たり");
                    break;
                }
            }
            Console.WriteLine("お疲れ様でした");
        }
    }
}
