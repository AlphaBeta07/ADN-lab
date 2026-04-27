using System;

class Multicast_Deligate
{
    // Step 1: Create a delegate
    public delegate void MyDelegate();

    static void Message1()
    {
        Console.WriteLine("Hello");
    }

    static void Message2()
    {
        Console.WriteLine("Welcome");
    }

    static void Message3()
    {
        Console.WriteLine("To C# Multicast Delegate");
    }

    static void Main()
    {
        // Step 2: Create delegate object
        MyDelegate obj;

        // Step 3: Add methods
        obj = Message1;
        obj += Message2;
        obj += Message3;

        // Step 4: Call delegate
        obj();
    }
}
