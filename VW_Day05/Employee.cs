using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VW_Day05
{
    //Step2
    //employee class has written 
    //custom attribute
    [Author_Attrib("Anant Saini","\nThat's employe","6.9")]
    class Employee
    {
        //string id;
        //string name;

     
            //additionalinformation belongs to method messsage to compiler
            [ObsoleteAttribute("This method is deprecated",true)]

        public void CalculateSalary()
        {
            //old law
        }
        public void CalculateSalary(int x, int y)
        {

        }
    }
}
