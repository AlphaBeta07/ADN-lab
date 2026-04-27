using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Car
    {
        string model;
        int year;
        public Car()
        {
            model = "BMW M4";
            year = 2020;
        }

        public Car(string modelName, int modelYear)
        {
            model = modelName;
            year = modelYear;
        }
        static void Main(string[] args)
        {
            Car c1 = new Car();
            Console.WriteLine("Car Model: " + c1.model);
            Console.WriteLine("Car Year: " + c1.year);

            Car c2 = new Car("GTR", 2021);
            Console.WriteLine("Car Model: " + c2.model);
            Console.WriteLine("Car Year: " + c2.year);
        }
    }
}
