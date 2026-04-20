using System;
using System.Collections.Generic;
using System.Text;

namespace Exp2
{
    abstract class Animal2
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Pig2 : Animal2
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }
    internal class AbstractClass
    {
        public static void abstratClass ()
        {
            Pig2 myPig = new Pig2(); // Create a Pig object
            myPig.animalSound();  // Call the abstract method
            myPig.sleep();  // Call the regular method
        }
    }
}
