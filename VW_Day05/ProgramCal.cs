using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VW_Day05
{

    class ProgramCal
    { 
        delegate void mydel(int x, int y);
        public static void Main(string[] args)
        {
            CalcuDeleg cl = new CalcuDeleg();
            mydel a, b, c, d;

            a = cl.Add;
            a.Invoke(5, 2);
            b = cl.Sub;
            b.Invoke(5, 2);
            c = a+b;
            c.Invoke(5,1);
            d = a-b;
            d.Invoke(6,2);

            Console.Read();
        }
    }
}
