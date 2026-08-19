using System;

namespace My28thProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // string interpolation = allows us to insert variables into a string literal
            //                                       precede a string literal with $
            //                                       {} are placeholder


            String firstName = "Bro";
            String lastName = "Code";
            int age = 21;

            //Console.WriteLine("Hello"  + firstName + " " + lastName);
            //Console.WriteLine("You are " + age + " years old");

            Console.WriteLine($"Hello {firstName} {lastName}");
            Console.WriteLine($"You are {age, 5} years old");


        }
    }
}