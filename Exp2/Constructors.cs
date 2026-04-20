using System;
using System.Collections.Generic;
using System.Text;

namespace Exp2
{
    internal class Constructors
    {
        public string model;  // Create a field

        // Create a class constructor for the Car class
        public Constructors()
        {
            model = "Mustang"; // Set the initial value for model
        }

        public static void constructors()
        {
            Constructors Ford = new Constructors();  // Create an object of the Car Class (this will call the constructor)
            Console.WriteLine("Model:" + Ford.model);  // Print the value of model
        }
    }
}
