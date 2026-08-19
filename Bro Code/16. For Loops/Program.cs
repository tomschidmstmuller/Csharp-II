using System;

namespace My15thProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loop = repeats some code a FINITE amount of times

           /*
            * or (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
           *
           */
           for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Happy New Year");
        }
    }
}