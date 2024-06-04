using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice0529
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Profile sato = new Profile("sato", 60);
            sato.intro();
            sato.result_show("Japanese", 80);
            sato.average = sato.average_calc(80, 70, 85);
            sato.result_show("total", sato.average);
        }
    }
}
