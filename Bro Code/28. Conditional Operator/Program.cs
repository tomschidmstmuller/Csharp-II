using System;

namespace My27thProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // conditional operator = used in conditional assignment if a condition is true/false
            // (condition) ? x : y

            double temperature = 10;
            //String message;

            /*
            if (temperature >= 15)
            {
                message = "It's warm outside";
            }
            else
            {
                message = "It's cold outside";
            }
                Console.WriteLine(message);
            */


            Console.WriteLine((temperature >= 15) ? "It's warm outside" : "It's cold outside");
        }
    }
}