using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMembers
{
    internal class Car
    {
        string color;
        int maxSpeed;

        public void fullThrottle(int maxSpeed) 
        {
            Console.WriteLine("The car is going as fast as "+maxSpeed+" KM/Hr");
        }
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.fullThrottle(200);

            Car c2 = new Car();
            c2.fullThrottle(300);
        }
    }
}
