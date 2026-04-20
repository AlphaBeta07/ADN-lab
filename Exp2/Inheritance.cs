using System;
using System.Collections.Generic;
using System.Text;

namespace Exp2
{
    class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car2 : Vehicle  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field
    }
    internal class Inheritance
    {
        public static void inheritanceCode()
        {
            // Create a myCar object
            Car2 myCar = new Car2();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine("Car Brand:" + myCar.brand + "," + "Car Model:" +myCar.modelName);
        }
    }
}
