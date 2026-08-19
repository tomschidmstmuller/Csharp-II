using System;

namespace My22ndProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // medthod = performs a section of code, whenever it's called "invoke"
            //                     benefit = Let's us reuse code w/o writing it multple time

            String name = "Bro";
            int age = 21;

            //singHappyBirthday();
            //singHappyBirthday();
            singHappyBirthday(name, age);
            

        }
        static void singHappyBirthday(String name, int age)
        {
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine($"Happy Birthday dear {name}!");
            Console.WriteLine($"You are {age} years old");
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine();
        }
    }
}