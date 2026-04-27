using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Animal  // Base class (parent) 
    {
        public virtual void animalSound() //virtual keyword allows this method to be overridden in derived classes
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound() //override keyword indicates that this method overrides a base class method
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound() 
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myPig = new Pig();  
            Animal myDog = new Dog();  

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
        }
    }
}

// Output without virtual and override keywords:
// The animal makes a sound
// The animal makes a sound
// The animal makes a sound

// Output with virtual and override keywords:
// The animal makes a sound
// The pig says: wee wee
// The dog says: bow wow

