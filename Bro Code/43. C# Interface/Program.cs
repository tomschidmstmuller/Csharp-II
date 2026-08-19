using System;

namespace My42ndProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Rabbit, Hawk, and Fish
            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            // Call the Flee and Hunt methods on each instance
            rabbit.Flee();
            hawk.Hunt();
            fish.Flee();
            fish.Hunt();
        }

        interface IPrey
        {
            void Flee();
        }

        interface IPredator
        {
            void Hunt();
        }

        class Rabbit : IPrey
        {
            public void Flee()
            {
                Console.WriteLine("The rabbit runs away!");
            }
        }

        class Hawk : IPredator
        {
            public void Hunt()
            {
                Console.WriteLine("The hawk is searching for food!");
            }
        }

        class Fish : IPrey, IPredator
        {
            public void Flee()
            {
                Console.WriteLine("The fish swims away!");
            }

            public void Hunt()
            {
                Console.WriteLine("The fish is searching for small fishes!");
            }
        }
    }
}
