using Exp1;

class HelloWorld
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine();

        //sum of two numbers
        Console.WriteLine("Sum of Two Numbers.");
        addTwoNumber.addNumbers();
        Console.WriteLine();

        //sum of array elements.
        Console.WriteLine("Sum of Array Elements.");
        SumOfArray.Sum();
        Console.WriteLine();

        //arithemetic operations
        Console.WriteLine("Arithemetic operations.");
        arithmetic_operations.arithemetic_opr();
        Console.WriteLine();

        //factorial of numbers
        Console.WriteLine("Factorial of Number.");
        Factorial.calculateFact();
        Console.WriteLine();

        //W3School Experiments
        Experiments.Exp1();

    }
}