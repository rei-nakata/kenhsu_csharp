using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objective_adv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car toyota = new Car(10);
            toyota.fuel_show();
            toyota.SetFuel(30);
            //Console.WriteLine(toyota.fuel);
            Console.WriteLine(toyota.GetFuel());


            Car lexus = new Car(20);
            lexus.fuel_show();

            City Japan = new City("横浜");
            Japan.show();
            //Japan.name = "神戸";
            //Japan.Name = "神戸";
            Console.WriteLine(Japan.Name);

            CharaPower sato = new CharaPower("sato", 60, 100);
            //sato.Name = "sato";
            //sato.Age = 60;
            sato.show("bench press");
            sato.Power = 120;
            Console.WriteLine("name{0},age{1},show{2}",sato.Name, sato.Age, sato.Power);
            sato.show_power(530000);


            Product eraser = new Product("eraser", 80);
            eraser.show();
            eraser.show(eraser.Name, eraser.Price);

            Stationery pencil = new Stationery("pencil", 100);
            pencil.show();
            pencil.show(pencil.Name, pencil.Price);
        }
    }
}
