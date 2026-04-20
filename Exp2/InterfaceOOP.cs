using System;
using System.Collections.Generic;
using System.Text;

namespace Exp2
{
    interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
    }

    // Pig "implements" the IAnimal interface
    class Pig3 : IAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }
    internal class InterfaceOOP
    {
        public static void interfaceOOP()
        {
            Pig3 myPig = new Pig3();  // Create a Pig object
            myPig.animalSound();
        }
    }
}
