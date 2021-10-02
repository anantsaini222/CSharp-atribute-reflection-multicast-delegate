using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VW_Day05
{
    //Step1
    [AttributeUsage(AttributeTargets.Class,AllowMultiple =false)]
    public class Assignment01 : Attribute
    {
        public string tittle;
        public string period;
        public int page;

        public Assignment01(string tittle, string period, int page)
        {
            this.tittle = tittle;
            this.period = period;
            this.page = page;
        }
    }
    [Assignment01("Hospital Mangement","Weekly",32)]
    //Not allowed
    class SalesReport
    {
        int sales;
        string salesPerson;
        public SalesReport(int sales,string salesPerson)
        {
            this.sales = sales;
            this.salesPerson = salesPerson;
        }
    }
    class ReadReport
    {
        public static void Main()
        {
            SalesReport s = new SalesReport();
            Type t = s.GetType();
            
            foreach(Attribute a in t.GetCustomAttributes(true))
            {
                //Console.WriteLine(t);
                Assignment01 r = (Assignment01)a;
                Console.WriteLine("Report Title is {0} ", r.tittle);
                Console.WriteLine("Periods {0} ", r.period);
                Console.WriteLine("No. of Pages {0} ", r.page);
                Console.Read();
            }
        }
    }

}
