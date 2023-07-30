using System;

namespace AnimalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            dog.DisplayAnimalInfo();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    class Animal
    {
        public void DisplayAnimalInfo()
        {
            Console.WriteLine("I am an animal");
        }
    }

    class Dog : Animal
    {
        public new void DisplayAnimalInfo()
        {
            base.DisplayAnimalInfo();
            Console.WriteLine("I have four legs");
        }
    }
}
