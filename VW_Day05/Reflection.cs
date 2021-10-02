using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection;

namespace VW_Day05
{
    class Reflection
    {
        static void Main()
        {
            //reflection of type which we have written
            //Type t = typeof(System.Collections.ArrayList);
            //Console.WriteLine("Type 0 is {0}", t.IsClass);
            //MethodInfo[] methods = t.GetMethods();
            //foreach (MethodInfo m in methods)
            //{
            //    Console.WriteLine("Method Name - {0} and Is Public {1} ", m.Name, m.IsAbstract);
            //}
            //ConstructorInfo[] constructs = t.GetConstructors();
            //foreach (ConstructorInfo m in constructs)
            //{
            //    Console.WriteLine(m.Name);
            //    Console.WriteLine(m.IsStatic);
            //}

            MethodInfo method;
            Object[] args = new object[] { 4, 9 };
            Assembly asm = Assembly.LoadFrom(@"C:\Users\anant\Desktop\.NET\Library_Demo\Library_Demo\bin\Debug");

            Type[] tp = asm.GetTypes();
            foreach (Object o in tp)
            {
                Console.WriteLine(o.ToString());
            }

            foreach (Type t in tp)
            {
                method = t.GetMethod("AddNumber");
                string typname = t.FullName;
                Console.WriteLine(typname);  //demo calculator
                                                                                //Late binding method

                Object o = asm.CreateInstance(typname);
                Object result = t.InvokeMember(method.Name,
                    BindingFlags.Public | BindingFlags.InvokeMethod
                    | BindingFlags.Instance, null, o,args);
                Console.WriteLine(result.ToString());
                Console.Read();
            }
        }
    }
}