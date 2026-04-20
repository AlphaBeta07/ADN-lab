using Exp1;
using System;
using System.Collections.Generic;
using System.Text;

class Experiments
{
    //Function
    public static void add(int number1, int number2 = 20)
    {
        Console.WriteLine("Addition = " + number1 + number2);
    }

    public static void add(String st1, String st2)
    {
        Console.WriteLine("Concatination of Strings = " + st1 + st2);
    }

    public static void Exp1()
    {
        //variables
        Console.WriteLine("Variables in C#.");
        int myNum = 20;
        myNum = 5;
        Console.WriteLine(myNum);
        Console.WriteLine();

        //multiple variables
        Console.WriteLine("Multiple Variables in C#.");
        int x, y, z;
        x = y = z = 50;
        Console.WriteLine(x + y + z);
        Console.WriteLine();

        //Data types
        Console.WriteLine("Data types in C#.");
        long myNum2 = 15000000000L;
        Console.WriteLine(myNum2);

        float myNum3 = 5.75F;
        Console.WriteLine(myNum3);

        float myNum4 = 5.75F;
        Console.WriteLine(myNum4);

        bool isCSharpFun = true;
        Console.WriteLine(isCSharpFun);

        char myGrade = 'B';
        Console.WriteLine(myGrade);

        string greeting = "Hello World";
        Console.WriteLine(greeting);
        Console.WriteLine();

        //Implicit type casting
        Console.WriteLine("Implicit type casting.");
        int myInt = 9;
        double myDouble = myInt;

        Console.WriteLine(myInt);
        Console.WriteLine(myDouble);
        Console.WriteLine();

        //Explicit type casting
        Console.WriteLine("Explicit type casting.");
        double myDoubleNo = 9.78;
        int myIntNo = (int) myDoubleNo;

        Console.WriteLine(myDouble);
        Console.WriteLine(myIntNo);
        Console.WriteLine();

        //Type conversion methods
        Console.WriteLine("Type conversion methods.");
        int myIntNo1 = 10;
        double myDoubleNo1 = 5.25;
        bool myBool = true;

        Console.WriteLine(Convert.ToString(myIntNo1));    // convert int to string
        Console.WriteLine(Convert.ToDouble(myIntNo1));    // convert int to double
        Console.WriteLine(Convert.ToInt32(myDoubleNo1));  // convert double to int
        Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
        Console.WriteLine();

        //User Input
        Console.WriteLine("User Input.");    
        Console.WriteLine("Enter username:");
        string userName = Console.ReadLine();
        Console.WriteLine("Username is: " + userName);

        //Taking int as a input
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your age is: " + age);
        Console.WriteLine();

        //Math
        Console.WriteLine("Maths Operations.");    
        Console.WriteLine(Math.Max(5, 10));
        Console.WriteLine(Math.Min(5, 10));
        Console.WriteLine(Math.Sqrt(5));
        Console.WriteLine(Math.Abs(-30));
        Console.WriteLine(Math.Round(8.7));
        Console.WriteLine();

        //Strings
        Console.WriteLine("Strings in C#.");
        string greeting2 = "Nice to meet you!";
        Console.WriteLine(greeting2);
        Console.WriteLine("Length of Greeting:" + greeting2.Length);

        Console.WriteLine(greeting2.ToUpper());
        Console.WriteLine(greeting2.ToLower());
        Console.WriteLine(); 

        //Concatination
        Console.WriteLine("String Concatination.");
        string firstName = "John ";
        string lastName = "Doe";
        string name = firstName + lastName;
        Console.WriteLine(name);
        Console.WriteLine();

        //String Interpolation
        Console.WriteLine("String Interpolation.");
        string firstName1 = "John";
        string lastName1 = "Doe";
        string name1 = $"My full name is: {firstName1} {lastName1}";
        Console.WriteLine(name1);
        Console.WriteLine();

        //Accesing String
        Console.WriteLine("Accesing Strings.");    
        string myString = "Hello";
        Console.WriteLine(myString[1]);

        //Special Characters
        string txt = "We are the so-called \"Vikings\" from the north.";
        Console.WriteLine(txt);
        Console.WriteLine();

        //If-Else
        Console.WriteLine("IF Else in C#.");
        int time = 20;
        if (time < 18)
        {
            Console.WriteLine("Good day.");
        }
        else
        {
            Console.WriteLine("Good evening.");
        }
        Console.WriteLine();

        //Else IF
        Console.WriteLine("Else IF in C#.");
        int time2 = 22;
        if (time2 < 10)
        {
            Console.WriteLine("Good morning.");
        }
        else if (time2 < 20)
        {
            Console.WriteLine("Good day.");
        }
        else
        {
            Console.WriteLine("Good evening.");
        }
        Console.WriteLine();

        //Short hand if else
        Console.WriteLine("Short hand if else in C#.");    
        Console.WriteLine("Enter age to check:");
        int newAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Person is " + (newAge > 18 ? "Adult" : "Not Adult"));
        Console.WriteLine();

        //Switch Case
        Console.WriteLine("Switch Case in C#.");
        int day = 4;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Looking forward to the Weekend.");
                break;
        }
        Console.WriteLine();

        //While Loop
        Console.WriteLine("While loop in C#.");
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine(i);
            i++;
        }
        Console.WriteLine();

        //Do While loop
        Console.WriteLine("Do While loop in C#.");
        int i1 = 0;
        do
        {
            Console.WriteLine(i);
            i1++;
        }
        while (i1 < 5);
        Console.WriteLine();

        //For loop
        Console.WriteLine("For loop in C#.");
        for (int i3 = 0; i3 <= 10; i3 = i3 + 2)
        {
            Console.WriteLine(i3);
        }
        Console.WriteLine();

        //For Each loop
        Console.WriteLine("For Each loop in C#.");
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        foreach (string i4 in cars)
        {
            Console.WriteLine(i4);
        }
        Console.WriteLine();

        //Break 
        Console.WriteLine("Break in C#.");
        for (int i5 = 0; i5 < 10; i5++)
        {
            if (i5 == 4)
            {
                break;
            }
            Console.WriteLine(i5);
        }
        Console.WriteLine();

        //Continue
        Console.WriteLine("Continue in C#.");
        for (int i6 = 0; i6 < 10; i6++)
        {
            if (i == 4)
            {
                continue;
            }
            Console.WriteLine(i);
        }
        Console.WriteLine();

        //Arrays
        Console.WriteLine("Arrays in C#.");
        string[] cars2 = { "Volvo", "BMW", "Ford", "Mazda" };
        Console.WriteLine(cars2[0]);
        cars2[0] = "Opel";
        Console.WriteLine(cars2[0]);
        Console.WriteLine();

        //Sort Array
        Console.WriteLine("Sorting in Arrays.");
        int[] myNumbers = { 5, 1, 8, 9 };
        Array.Sort(myNumbers);
        foreach (int number in myNumbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();

        //Multidimensional Array
        Console.WriteLine("Multidimensional Array in C#.");
        int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
        Console.WriteLine(numbers[0, 2]);
        Console.WriteLine();

        //Function with parameters
        Console.WriteLine("Methods in C#.");
        add(30, 50);
        add(30);
        Console.WriteLine();

        //Method Overloading
        Console.WriteLine("Method Overloading in C#.");
        add("Atharv", "Niprul");
        Console.WriteLine();
    }
}