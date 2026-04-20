using System;
using System.Collections.Generic;
using System.Text;

namespace Exp2
{
    internal class AccessModifiers1
    {
        private string model = "Mustang";
        public string model1 = "Muscle";

        public string getPrivateModel()
        {
            return this.model;
        }
    }

    class AccessModifiers
    {
        public static void accessModifiers()
        {
            AccessModifiers1 myObj = new AccessModifiers1();
            Console.WriteLine("Accessing Private Filed of Class");
            Console.WriteLine("Car Model:" + myObj.getPrivateModel());
            //Console.WriteLine(myObj.model); //not accessible
        }

        public string model1 = "Sedan";
        public static void getModel()
        {
            AccessModifiers1 myObj = new AccessModifiers1();
            Console.WriteLine("Accessing Public Field of Class");    
            Console.WriteLine("Car Model:" + myObj.model1);
        }
    }
}
