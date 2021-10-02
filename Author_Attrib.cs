using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VW_Day05
{
    //reflection is reading metadata
    //attribute is writting metadata

        //Step1
        //[AttributeUsage(AttributrTargets.All | Attribute.Targets.Method,AllowMultiple =true,Inherited = true}
    public class Author_Attrib : Attribute
    {
        public string message;
        public string name;
        public string version;

        public Author_Attrib(string name, string message, string version)
        {
            this.message = message;
            this.name = name;
            this.version = version;
        }
    }
}
