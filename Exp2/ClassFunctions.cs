using System;
using System.Collections.Generic;
using System.Text;

namespace Exp2
{
    internal class ClassFunctions
    {
        string color;                 // field
        int maxSpeed;                 // field
        public void fullThrottle()    // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }

        public static void classFunctions()
        {
            ClassFunctions myObj = new ClassFunctions();
            myObj.fullThrottle();  // Call the method
        }
    }
}
