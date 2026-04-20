using System;
using System.Collections.Generic;
using System.Text;

namespace Exp2
{
    interface IFirstInterface
    {
        void myMethod(); // interface method
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("From First Interface.");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("From Second Interface.");
        }
    }
    internal class MultipleInterface
    {
        public static void multipleInterface()
        {
            DemoClass myObj = new DemoClass();
            myObj.myMethod();
            myObj.myOtherMethod();
        }
    }
}
