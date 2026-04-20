using Exp4;
using System;

class Program
{
    //single cast delegate.
    public delegate void displayName(string dept);

    //multicast delegate.
    public delegate void ResultAnnounce(string name);
  
    //method for single cast.
    public static void displayDepartment(string dept)
    {
        Console.WriteLine("From " + dept + " Department");
    }

    //methods for multicast.
    public static void displayResult(string name)
    {
        Console.WriteLine("Result for " + name); 
    }

    public static void sendSMS(string name)
    {
        Console.WriteLine("SMS send to " + name);
    }

    public static void saveToDB(string name)
    {
        Console.WriteLine("Result Stored at name " + name);
    }
    public static void Main()
    {
        ////single cast calling.
        //displayName deptName = displayDepartment;
        //deptName("CSE AI-ML");
        //Console.WriteLine();

        ////multicast calling.
        //ResultAnnounce result = displayResult;
        //result += sendSMS;
        //result += saveToDB;

        //Console.WriteLine("Result:");
        //result("Atharv");

        //2. lambda with delegates.
        //Lambda.LambdaFunctions();

        //3. Sorting Strings List
        SortingList.SortList();
    }
}
