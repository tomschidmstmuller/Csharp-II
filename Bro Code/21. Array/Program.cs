using System;
using System.Reflection;

namespace My20thProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // array = a variable that can store multple values. fixed size

            String[] cars = new string[3];

            //String[] cars = { "BWM", "Mustang", "Corvette" };

            cars[0] = "Tesla";
            cars[1] = "Tesla";
            cars[2] = "Tesla";

            //Console.WriteLine(cars[0]);
            //Console.WriteLine(cars[1]);
            //Console.WriteLine(cars[2]);

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

        }
    }
}
