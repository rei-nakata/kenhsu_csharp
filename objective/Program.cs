using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace objective
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //オブジェクト作成、インスタンス作成
        Chara tanikawa =new Chara();
        //フィールドの値を定義する
            tanikawa.name = "tanikawa";
            tanikawa.age = 27;
            tanikawa.show();

        Chara sato = new Chara();
            sato.name = "sato";
            sato.age = 60;
            sato.show();

        Student s = new Student();
            s.name = "鈴木ひまり";
            s.grade = 3;
            s.show();

        Tax_price product = new Tax_price();
            product.price = 100;
            product.rate = 10;
            product.calc();
            product.calc_arg(1800, 10);
            product.calc_arg(product.price * 0.8, 10);
            double sum = product.calc_arg_return(500, 10);
            sum += product.calc_arg_return(600, 10);
            Console.WriteLine(sum);

        RPG fighter = new RPG("戦士", 10);
            //fighter.job = "戦士";
            //fighter.level = 10;
            fighter.total_power = fighter.show_total(10, 30, 50);
            fighter.show();
            fighter.show_attack("戦う", 10);
            fighter.show_attack("タックル", 30);
            fighter.show_attack("剣できる", 50);
            fighter.show_attack("合計", fighter.total_power);


        RPG hero = new RPG("主人公", 30);
            hero.show();

        }
            
    }

}
