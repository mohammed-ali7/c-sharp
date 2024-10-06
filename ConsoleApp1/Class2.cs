using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    // Abstract class
    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void makeSound();
        // Regular method
        public void Sleep()
        {
            Console.WriteLine("make sound");
        }
    }

    // Derived class (inherit from Animal)
    class Dog : Animal
    {
        public override void makeSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("barking");
        }


        class Cat : Animal
        {
            public override void makeSound()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("meo");
            }

            static void Main(string[] args)
            {
                Dog myDog = new Dog(); // Create a dog object
                myDog.makeSound();  // Call the abstract method

                Cat myCat = new Cat(); // Create a cat object
                myCat.makeSound();  // Call the abstract method


            }
        }
    }
}