using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba10_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string str_1 = "Slastena";
            string str_2 = "Russia";
            int m = 250;
            int mil = 100;
            int ex = 60;
            int ch = 1;
            int x = 12;
            int y = 10;
            int k = 2020;

            Icecream ice1 = new Icecream();
            ice1.Init_icecream_in();
            ice1.Display();
        }
    }
}
