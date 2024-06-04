using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice0530
{
    public class Employee
    {
        private string name;
        private int age;
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName() 
        {
            return this.name;
        }
        public int GetAge()
        {
            return this.age;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }

    }

    public class Person
    {
        public string name;
        public int age;
    }

    public class Student : Person
    {
        public string studentId;
    }

    public class Animal
    {
        public virtual void sound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }
    public class Dog:Animal
    {
        public override void sound()
        {
            Console.WriteLine("Dog barks");
        }
    }
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    public abstract class Shape
    {
        public abstract double CalculateAread();
    }
    public class Rectangle : Shape
    {
        public double width;
        public double height;
        public override double CalculateAread()
        {
            return this.width * this.height;
        }
    }

    public interface IMovable
    {
        void Move(int distance);
    }

    public class Car: IMovable
    {
        public int mileage;
        public void Move(int distance)
        { 
            mileage+= distance;
        }
    }
}
