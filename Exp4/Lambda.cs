using System;
using System.Collections.Generic;
using System.Text;

namespace Exp4
{
    public class Lambda
    {
        //single casting delegate.
        public delegate void showName(string name);
        public delegate void processResult(List<int> marks);

        public static void LambdaFunctions()
        {
            //single casting 
            showName name = (name) => Console.WriteLine("Result for " +  name);
            name("Atharv");

            //multi casting
            processResult result = (marks) => Console.WriteLine("Total Obtained Marks = " + marks.Sum());
            result += (marks) => Console.WriteLine("Average = " + marks.Average());
            result += (marks) =>
            {
                double avg = marks.Average();

                if (avg >= 90)
                    Console.WriteLine("Grade: A");
                else if (avg >= 75)
                    Console.WriteLine("Grade: B");
                else if (avg >= 60)
                    Console.WriteLine("Grade: C");
                else
                    Console.WriteLine("Grade: Fail");
            };

            result(new List<int> { 90, 92, 96, 85, 91 });
        }
    }
}
