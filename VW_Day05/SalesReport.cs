using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemos
{
    [ReportAttributeAssignment("Ransomware Attack", "monthly", 800)]
    class SalesReport
    {
        string report_id;
        double report_price;
        public SalesReport(string report_id,double report_price)
        {
            this.report_id = report_id;
            this.report_price = report_price;
        }
        [ReportAttributeAssignment("Ransomware Attack", "monthly", 800)]
        public double Discount()
        {
            Console.WriteLine("Press y if this is  an old customer");
            string a = Console.ReadLine();
            if(a=="y")
            {
                report_price = report_price - (report_price * 0.05);
                return report_price;
            }
            else
            {
                return report_price;
            }
        }
    }
}
