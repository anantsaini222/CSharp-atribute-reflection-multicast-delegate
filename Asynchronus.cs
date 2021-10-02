using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VW_Day05
{
    delegate string strDelegate(string str);
    class Asynchronus
    {
        //async delegates - parallel
        // Iscomplete - job is done - 
        //begin not invoke
        public static void Main()
        {
            strDelegate caller = new strDelegate(LongHoursWorking);
            IAsyncResult result = caller.BeginInvoke(".net c# sharp", null, null);
            Console.WriteLine("Function Started");
            for (int i = 0; i < 500; i++) ;
            if (result.IsCompleted)
            {
                string returnVal = caller.EndInvoke(result);
                Console.WriteLine("Value Returned {0} ", returnVal);
            }
            Console.Read();
        }
        public static string   LongHoursWorking(string str)
        {
            for (int i = 0; i < 1000; i++) ;
                return str.ToUpper();
        } 
    }
}
