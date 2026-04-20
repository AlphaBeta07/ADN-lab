using System;
using System.Collections.Generic;
using System.Text;

namespace Exp2
{
    internal class Properties
    {
        private string name; // field
        public string Name   // property
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Program
    {
        public static void propertiesCode()
        {
            Properties myObj = new Properties();
            myObj.Name = "Liam";
            Console.WriteLine("Person Name:" + myObj.Name);
        }
    }
}
