using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VW_Day05
{
    class AttributeDemo
    {
        public static void Main()
        {
            //    //object is created by Anant
            //    Employee e = new Employee();
            //    //e.CalculateSalary();
            //    e.CalculateSalary(10, 20);

            //Step3
            //Reading custom attribute metadata
            Employee e = new Employee();
            Type t = e.GetType();

            foreach(Attribute a in t.GetCustomAttributes(true))
            {
                Author_Attrib aa = (Author_Attrib)a;
                Console.WriteLine("Custom attribute description {0} ", aa.message);
                Console.WriteLine("Author attribute Name {0} ", aa.name);
                Console.WriteLine("Version of class Employee {0} ", aa.version);
                Console.Read();
            }

            //Product p = new Product();
            //Type t1 = p.GetType();
            ////create new class and you can create there also
            //foreach (Attribute a in t.GetCustomAttributes(true))
            //{
            //    Author_Attrib aa = (Author_Attrib)a;
            //    Console.WriteLine("Custom attribute description {0} ", aa.message);
            //    Console.WriteLine("Author attribute Name {0} ", aa.name);
            //    Console.WriteLine("Version of class Employee {0} ", aa.version);
            //    Console.Read();
            //}
        }
    }
}
