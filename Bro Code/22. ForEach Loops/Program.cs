using System;

namespace My21stProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // foreach loop = a simple way to iterate over an array, but it's less flexible

            String[] cars = { "BMW", "Mustang", "Convette" };

            /*for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }*/

            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}