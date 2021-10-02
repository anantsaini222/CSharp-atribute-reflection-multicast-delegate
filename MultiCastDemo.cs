using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VW_Day05
{
    class MultiCastDemo
    {
        delegate void mydel(string s);
        public static void Main()
        {
            Greet g = new Greet();
            mydel a, b, c, d;
            a = g.GoodMorning;
            a.Invoke("Sumita");
            b = g.GoodBye;
            b.Invoke("Amita");
            c =a+b;
            c.Invoke("Lailita");

            d = c - a;
            d.Invoke("Babita");
            Console.Read();
        }
    }
}
