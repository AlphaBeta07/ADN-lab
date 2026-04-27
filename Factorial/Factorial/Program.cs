using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //fctorial of a number
            Console.WriteLine("Enter a number to calculate its factorial:");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("Factorial of " + number + " is: " + factorial);

        }
    }
}
