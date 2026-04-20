using System;
using System.Collections.Generic;
using System.Text;

namespace Exp1
{
    internal class Factorial
    {
        public static void calculateFact()
        {
            int num;

            Console.Write("Enter Number:");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Factorial of " + num + " = " + fact(num));
        }

        private static long fact(int num)
        {
            if(num <= 1)
            {
                return 1;
            }
            else
            {
                return num * fact(num - 1);
            }
        }
    }
}
