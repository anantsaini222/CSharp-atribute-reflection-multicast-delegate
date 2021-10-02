using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VW_Day05
{
    //Step2
    //custom attribute
    class CalNetSalary
    {
        static int salary_per_Day = 100;
        static int atten;
        static int net_salary;

        public void Calattendance()
        {
            Console.WriteLine("Enter Monthly attendance of Employee");
            atten = Int32.Parse(Console.ReadLine());

        }
        public void CalBasicSalary()
        {
            int c = atten * salary_per_Day;
            net_salary += c;
            Console.WriteLine("Basic Salary is for {0} day is Rs: {1) \n", atten, c);

        }
        public void CalAllowance()
        {
            if(atten>28)
            {
                net_salary += (10 * net_salary) / 100;
                Console.WriteLine("Congrats!! You did a good job.");
                Console.WriteLine("Your salary after added allowance of 10% is Rs.{0}\n", net_salary);
            }
            else
            {
                net_salary += (5 * net_salary) / 100;
                Console.WriteLine("Congrats!!");
                Console.WriteLine("true/false");
                bool s1 = bool.Parse(Console.ReadLine());
                if(s1)
                {
                    net_salary += (2 * net_salary) / 100;
                }

            }
            void CalDeduction()
            {
                Console.WriteLine("Do you avail transport and bus facility");
                Console.WriteLine("true/false");
                bool s1 = bool.Parse(Console.ReadLine());
                if(s1)
                {
                    net_salary -= (2 * net_salary) / 100;
                }
            }
            public void total_Salary()
        {
                Console.WriteLine("Your totalsalary is {0} ", net_salary);
        }
            delegate void caldelegate();
            
            class SalReport
        {
            public static void Main()
            {
                CalNetSalary a = new CalNetSalary();
                caldelegate[] dalegate = new caldelegate[]
                {
                    new caldelegate(a.Calattendance),
                    new caldelegate(a.CalBasicSalary),
                    new caldelegate(a.CalAllowance),
                    new caldelegate(a.CalDeduction),
                    new caldelegate(a.total_Salary)
                 };
                caldelegate chain = (caldelegate)Delegate.Combine(delegate);
                chain.Invoke();
                Console.Read();
            }
        }

        }
    }
}

