using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objective
{
    public class Chara
    {
        public string name;
        public int age;
        public void show()
        {
            Console.WriteLine("名前；{0} 年齢;{1}", this.name, this.age);
        }
    }

    public class Student
    {
        public string name;
        public int grade;
        public void show()
        {
            Console.WriteLine("名前：{0} 学年：{1}", this.name, this.grade);
        }
        
    }

    public class Tax_price
    {
        public double price;
        public double rate;
        public void calc()
        {
            Console.WriteLine(this.price+this.price *this.rate/100);
        }
        public void calc_arg(double price_arg, double rate_arg)
        {
            Console.WriteLine(price_arg * (1 + rate_arg/100));
        }
        public double calc_arg_return(double price_arg, double rate_arg)
        {
            double result = price_arg + price_arg * rate_arg / 100;
            return result;
            //メソッド使用jに別の変数などに値を引き渡す結果
        }
    }

    public class RPG
    {
        public string job;
        public int level;
        public int total_power;

        //フィールドの初期値を決めるコンストラクタメソッドの定義
        public RPG(string job, int level)
        {
            this.job = job;
            this.level = level;
            Console.WriteLine("初期値設定完了");
        }

        //引数なし戻り値なし
        public void show()
        {
            Console.WriteLine("職は{0}でレベルは{1}です。", this.job, this.level);
        }
        //引数あり戻り値なし
        public void show_attack(string attack_name, int attack_para)
        {
            Console.WriteLine("{0}の攻撃力は{1}です。", attack_name, attack_para);
        }

        //引数あり戻り値あり
        public int show_total(int red, int blue, int green)
        {
            int result = red + blue + green;
            return result;
        }
        
    }
}
