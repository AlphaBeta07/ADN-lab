using System;
class Car
{
    string color = "White";
    public static void createObj()
    {
        Car myObj = new Car();
        Console.WriteLine("Car Color:" + myObj.color);
    }
}
