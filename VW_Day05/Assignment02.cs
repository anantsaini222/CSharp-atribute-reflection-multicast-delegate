using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VW_Day05
{
    //Delegate Assignment 
    class Assignment02
    {
        delegate int SalDelegate(int x);
        public static void Main()
        {
            Income ob1 = new Income();

            SalDelegate[] delegates = new SalDelegate[]
            {
                new SalDelegate(ob1.Attendance),
                new SalDelegate(ob1.BasicSal),
                new SalDelegate(ob1.allowance),
                new SalDelegate(ob1.deduct)
        };
            SalDelegate chain = (SalDelegate)Delegate.Combine(delegates);
            Console.WriteLine("\n---------------------------------------------------------------------");
            Console.WriteLine("         ***  Delegate Chaining Assignment  ***");
            Console.WriteLine("---------------------------------------------------------------------");

            int netSal = chain.Invoke(62);

            Console.WriteLine("\n\n---------------------------------------------------------------------");
            Console.WriteLine("   He will going to get {0} which we all know is insufficient ", netSal);
            Console.ReadLine();

        }
        class Income
        {
            static int netSal;
            int att = 0;
            public int Attendance(int x)
            {
                netSal = x;
                att = netSal / 30;
                att++;
                Console.WriteLine("\n\n\tYour Attendence in {0} months is : {1}\n", att,netSal);
                return netSal;
            }
            public int BasicSal(int x)
            {
                int sal=2000;
                Console.WriteLine("\tSalary for one day is  income is : {0}\n", sal);
                netSal = netSal * sal;
                Console.WriteLine("\tYour {0} months income is : {1}\n",att, netSal);
                return netSal;
            }
            public int allowance(int z)
            {
                int alw = 7000;
                Console.WriteLine("\tAllowance Given per month : {0}\n", alw);
                netSal = netSal + 7000;
                Console.WriteLine("\tNet Salary after including allowance will be : {0}\n", netSal);
                return netSal;
            }
            public int deduct(int x)
            {
                int dec = att*1200;
                Console.WriteLine("\tDeduction rate is : 5% i.e. for {0} months is :{1}\n",att,dec);
                netSal = netSal - dec;
                Console.WriteLine("\tNet Salary after deduction will be : {0}\n", netSal);
                return netSal;
            }
        }
    }
}
