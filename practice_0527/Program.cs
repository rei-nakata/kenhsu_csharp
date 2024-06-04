using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_0527
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            int a = 100;
            Console.WriteLine(a);
            Console.WriteLine("{0}点おめでとうございます",a);
            Console.WriteLine(a+"点おめでとうございます");
            const string B = "新宿太郎";
            //B = "品川花子";
            string c = "200";
            Console.WriteLine(a+c);
            int intC = int.Parse(c);
            Console.WriteLine(a+intC);

            double d = 6, e = 3;
            double f = (d + e) / 2;
            Console.WriteLine("d,eの平均値：{0}", f);
            int g = 10;
            Console.WriteLine(g);
            g += 30;
            Console.WriteLine(g);

            //配列
            int[] h = {11,22,33};
            Console.WriteLine(h[0]);

            string[] j = { "Tokyo", "Osaka", "Nagoya" };
            Console.WriteLine(j[1]);

            //ループ
            for (int i = 0; i < j.Length; i++)
            {
                Console.WriteLine(j[i]);
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("スタンプ");
            }

            for(int i = 0;i < 5; i++)
            {
                Console.WriteLine("I can do it");
            }

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 3; i < 6; i++)
            {
                Console.WriteLine(i);
            }

            //演習
            int num1 = 10, num2 = 20;
            int sum = num1 + num2;
            Console.WriteLine(sum);

            for (int i = 2; i < 6; i++)
            {
                Console.WriteLine(i);
            }

            string[] sports = { "soccer", "tennis", "basketball" };
            for (int i = 0; i < sports.Length; i++)
            {
                Console.WriteLine(sports[i]);
            }

            string[] fruits = { "apple", "orange", "banana" };
            for(int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }
            Console.WriteLine("{0}種類",fruits.Length);

            int[] dice = { 1, 6, 3 };
            for (int i = 0;i < dice.Length; i++)
            {
                Console.WriteLine(7 - dice[i]);
            }

            for(int i = 0; i<11; i++)
            { 
                Console.WriteLine(i); 
            }


            int[] k = { 1, 2, 3, 4, 5, 6 };
            int[] l = {};
            //for (int i = 0; i < k.Length; i++)
            //{
            //    l[i] = 2* k[i];
            //    Console.WriteLine(l[i]);
            //}

            foreach(int index in h)
            {
                Console.WriteLine(index);
            }

            int m = 10;
            if (m > 0)
            {
                Console.WriteLine("mは正の数");
            }
            else if (m < 0)
            {
                Console.WriteLine("mは負の数");
            }
            else
            {
                Console.WriteLine("kは0");
            }

            int n = 1;
            switch (n)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                default:
                    Console.WriteLine("値が違う");
                    break;
            }
            int o = 0;
            while (o < 3) 
            {
                Console.WriteLine("無限ループ");
                o++;
            }
        }
    }
}
