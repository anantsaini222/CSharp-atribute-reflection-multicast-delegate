using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VW_Day05
{
    class DelegChain
    {
        delegate int CalDelegate(int x, int y);
        public static void Main()
        {
            Calculator obj1 = new Calculator();
            Calculator obj2 = new Calculator();

            CalDelegate[] delegates = new CalDelegate[]
            {
                new CalDelegate(obj1.add),
                new CalDelegate(obj2.add),
                new CalDelegate(Calculator.subtract)
        };
            CalDelegate chain = (CalDelegate)Delegate.Combine(delegates);
            int result = chain.Invoke(40, 50);
            Console.WriteLine("Result is {0}",result);
            Console.ReadLine();
            //chain = (CalDelegate)Delegate.Remove(chain, delegates[2]);
            //Console.WriteLine("Result is {0}",result);
            //Console.Read();
        }
        class Calculator
        {
            static int result;
           
            public int add(int x,int y)
            {
                Console.WriteLine("Add Function");
                result = result + x + y;
                Console.WriteLine("Add Function {0}", result);
                return result;
            }
            public static int subtract(int x, int y)
            {
                Console.WriteLine("Subtract Function");
                result = result - 10;
                Console.WriteLine("Subtract Function {0} ", result);
                return result;
            }
        }
    }
}