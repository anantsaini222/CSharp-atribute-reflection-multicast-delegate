using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VW_Day05
{
    class Greet
    {
        //delegate void mydel(string s);
        //static void Main(String[] args)
        //{
        //    Greet g = new Greet();

        //    mydel md = g.GoodMorning;
        //    md.Invoking("Anant");

        //    Console.Read();
        //    )

        public void GoodMorning(String name)
        {
            Console.WriteLine("This is mOrning");
        }
        public void GoodEvening(String name)
        {
            Console.WriteLine("This is evening");
        }
        public void GoodBye(string name)
        {
            Console.WriteLine("This is Good Bye !!!!!");
        }
        }
    }
