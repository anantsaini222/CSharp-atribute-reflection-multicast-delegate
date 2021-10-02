using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
namespace ReflectionDemos
{
    class AssignmentDemo
    {
        public static void Main()
        {
            SalesReport s = new SalesReport("101",2000);
            Type t = s.GetType();
            foreach (Attribute a in t.GetCustomAttributes(true))
            {
                ReportAttributeAssignment aa = (ReportAttributeAssignment)a;
                Console.WriteLine("Report attribute title {0} ", aa.title);
                Console.WriteLine(" Period when it will release {0} ", aa.period);
                Console.WriteLine(" Number of Pages {0} ", aa.pages);
                
            }
            MethodInfo[] methodInfos = typeof(SalesReport).GetMethods();
            Console.WriteLine("Functions are:-");
            foreach (MethodInfo methodInfo in methodInfos)
            {
                Console.WriteLine(methodInfo.Name);
            }
           
            Console.WriteLine("The price on you purchase this book is:-"+s.Discount());
            Console.Read();
        }
    }
}
