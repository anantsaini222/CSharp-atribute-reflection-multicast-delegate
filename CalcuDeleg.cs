using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VW_Day05
{
    class CalcuDeleg
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public void Mutli(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public void Div(int x, int y)
        {
            Console.WriteLine(x / y); 
        }
    }
}
