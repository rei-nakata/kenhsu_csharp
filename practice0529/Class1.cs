using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice0529
{
    
    public class Profile
    {
        public string name;
        public int age;
        public double average;
        public Profile(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void intro()
        {
            Console.WriteLine("My name is {0}. I'm {1} years old", this.name, this.age);
        }
        public void result_show(string subject, double score)
        {
            Console.WriteLine("{0}'s score is {1}", subject, score);
        }
        public double average_calc(double subject1, double subject2, double subject3)
        {
            double ans = (subject1 + subject2 + subject3) / 3;
            return ans;
        }
    }
    
}
