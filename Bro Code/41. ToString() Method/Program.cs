using System;

namespace My40thProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            //ToString = converts an object to its string representation so that it is suitable for display

            Car car = new Car("Chevy", "Corvette", 2022, "blue");

            Console.WriteLine(car);

        }
    }
    class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public override string ToString()
        {
            String message = "This is a " + make + " " + model;
            return message;
        }
    }
}