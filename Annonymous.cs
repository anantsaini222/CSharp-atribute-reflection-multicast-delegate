using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VW_Day05
{
    class Annonymous
    {
        //unknown
        delegate void printer(string s);
        public static void Main()
        {
            printer p = delegate(string s)
            {
                Console.WriteLine("We are printing your name is : " + s);
            };
            p.Invoke("Anant");
            p = PrintData;
            p.Invoke("Saini");
            Console.Read();
        }
        public static void PrintData(string s)
        {
            Console.WriteLine("Your  name is : " + s);
        }
    }
}
