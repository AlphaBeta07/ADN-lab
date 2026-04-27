using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

//If you don't want other classes to inherit from a class, use the sealed keyword:
//    sealed class Vehicle
//    {
//      ...
//    }

//    class Car : Vehicle
//    {
//      ...
//    }

    class Animal
    {
        public void Speak()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    class Dog : Animal //Syntax for inheritance 
    {
        public void Bark()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Speak(); // Inherited method from Animal class
        }
    }
}
