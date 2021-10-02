using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VW_Day05
{
    //class BeepDemo
    //{
    //    //introp-interoperability
    //    [System.Runtime.InteropServices.DllImport("kernel32.dll", EntryPoint = "Beep")]


    //    //extern-browing - not native
    //    //return type-boolean
    //    static extern bool Beep(int frequency, int duration);
    //    public static void Main()
    //    {
    //        Beep(100, 11111);
    //        Console.Read();
    //    }

        class BeepDemo
        {
        [System.Runtime.InteropServices.DllImportAttribute("User32.dll", EntryPoint = "MessageBox")]
        public static extern int MessageBox(int h, string m, string c, int type);

        public static int Main()
        {
            string myString;
            Console.Write("Enter your message: ");
            myString = Console.ReadLine();
            return MessageBox(0, myString, "Anant", 0);

        }
        }
    }