using System;

namespace My14thProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // while loop = repeats some code while some condition remains true

            Console.WriteLine("Enter your name: ");
            String name = Console.ReadLine();

            while (name == "")
            {
                Console.WriteLine("Enter your name: ");
                 name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);



        }
    }
}