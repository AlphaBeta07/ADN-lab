using System;
namespace Exp1
{
    internal class addTwoNumber
    {
        public static void addNumbers()
        {
            Console.WriteLine("Enter 1st Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition = " + (num1 + num2));
        }
    }
}
