using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objective_adv
{
     public class Car
    {
        private int fuel;

        //コンストラクタ
        public Car(int fuel) 
        {
            this.fuel = fuel;
        }

        //メソッド
        public void fuel_show()
        {
            Console.WriteLine("燃料：{0}", this.fuel);
        }

        //セッターメソッド、ゲッターメソッドの定義
        public void SetFuel(int fuel)
        {
            if (fuel > 0)
            {
                this.fuel = fuel;
            }            
        }
        public int GetFuel()
        {
            return this.fuel;
        }
    }

    public class City
    {
        //フィールド
        private string name;

        //コンストラクタ
        public City(string name)
        {
            this.name = name;
        }

        //メソッド
        public void show()
        {
            Console.WriteLine(this.name);
        }

        //プロパティ
        public string Name
        {
            get { return this.name; }
            //set { this.name = value; }
        }
    }

    public class Chara
    {
        //field
        protected string name;
        protected int age;

        //constructor
        public Chara(string name, int age) 
        {
            this.name=name;
            this.age = age;
        }

        //method
        public virtual void show(string good)
        {
            Console.WriteLine("I'm good at {0}.", good);
        }

        //property
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            set { this.age = value; }
            get { return this.age; }
        }
    }

    //child_class
    public class CharaPower : Chara
    {
        //field
        protected int power;
        //constructor
        public CharaPower(string name, int age, int power):base(name,age)
        {
            this.power = power;
        }
        //method
        public void show_power(int power)
        {
            Console.WriteLine("My battle strength is {0}.", power);
        }
        //property
        public int Power
        {
            get { return this.power; }
            set { this.power = value; }
        }
        //override
        public override void show(string  good)
        {
            Console.WriteLine("I'm not good at {0}.", good);
            base.show(good);
        }
    }


    public class Product
    {
        //field
        protected string name;
        protected int price;

        //constructor
        public Product(string  name, int price)
        {
            this.name = name;
            this.price = price;
        }

        //method
        public virtual void show()
        {
            Console.WriteLine("There are no registered products.");
        }
        public virtual void show(string product, int price)
        {
            Console.WriteLine("product's name is {0}, that's price is {1}", product, price);
        }

        //property
        public string Name
        {
            get{ return this.name; }
            set { this.name = value; }
        }
        public int Price
        {
            set { this.price = value; }
            get { return this.price; }
        }
    }

    public class Stationery : Product
    {
        //field
        //constructor_override
        public Stationery(string name, int price):base(name,price)
        {

        }
        //method_override
        public override void show()
        {
            Console.WriteLine("show method");
        }
        public override void show(string product, int price)
        {
            Console.WriteLine("show method{0}{1}", product, price);
        }
        //property
    }

    //abstract
    public abstract class Bird
    {
        public abstract void sing();
    }

    public class Crow: Bird
    {
        public override void sing()
        {
            Console.WriteLine("ka-ka-");
        }
    }
    

}
