using System;

namespace Exp1
{
    internal class arithmetic_operations
    {
        public static void arithemetic_opr()
        {
            int num1, num2;
            string ch;
            do
            {
                Console.WriteLine(" *** Arithmetic Calculator *** ");
                Console.Write("Enter 1st Number:");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter 2nd Number:");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("+ Addition");
                Console.WriteLine("- Substration");
                Console.WriteLine("* Multiplication");
                Console.WriteLine("/ Division");
                Console.Write("Select Operation:");
                ch = Console.ReadLine();

                if(ch == "+")
                {
                    Console.WriteLine("Addition = " + (num1 + num2));
                    Console.Write("Do you want to exit enter your choice y or n:");
                    ch = Console.ReadLine();
                }
                else if(ch == "-")
                {
                    Console.WriteLine("Substraction = " + (num1 - num2));
                    Console.Write("Do you want to exit enter your choice y or n:");
                    ch = Console.ReadLine();
                }
                else if(ch == "*")
                {
                    Console.WriteLine("Multiplication = " + (num1 * num2));
                    Console.Write("Do you want to exit enter your choice y or n:");
                    ch = Console.ReadLine();
                }
                else if(ch == "/")
                {
                    if(num2 == 0)
                    {
                        Console.WriteLine("Can't Divide by Zero.");
                        return;
                    }
                    Console.WriteLine("Division = " + (num1 / num2));
                    Console.Write("Do you want to exit enter your choice y or n:");
                    ch = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                    return;
                }

            } while (ch != null && ch.ToLower() != "y");
        }
    }
}
