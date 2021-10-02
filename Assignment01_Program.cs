using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VW_Day05
{
    //Step3
    //Reading custom attribute metadata
    class Assignment01_Program
    {
        public static void Main()
        {
            SalReport s = new SalReport();
            Type t = s.GetType();
            Console.WriteLine("\n-----------------------------------------------------------------------------");
            Console.WriteLine("                    ***  Attribute Assignment  ***");
            Console.WriteLine("-----------------------------------------------------------------------------");

            foreach (Attribute r in t.GetCustomAttributes(true))
            {
               Assignment01 ab = (Assignment01)r;
                Console.WriteLine("\n\t\t    Report Tittle\t{0} ", ab.tittle);
                Console.WriteLine("\t\t    Update Period\t{0} ", ab.period);
                Console.WriteLine("\t\t    Total Pages\t{0} \n\n", ab.page);
              
            }

            FinReport f = new FinReport();
            Type t1 = f.GetType();

            foreach (Attribute e in t1.GetCustomAttributes(true))
            {
                Assignment01 ac = (Assignment01)e;
                Console.WriteLine("\t\t    Report Tittle\t{0} ", ac.tittle);
                Console.WriteLine("\t\t    Update Period\t{0} ", ac.period);
                Console.WriteLine("\t\t    Total Pages\t{0} ", ac.page);
                Console.Read();
            }
        }
    }
}
