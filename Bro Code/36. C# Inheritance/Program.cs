using System;

namespace My35thProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            car.Go();
            Console.WriteLine();

            Console.WriteLine(bicycle.speed);
            Console.WriteLine(bicycle.wheels);
            bicycle.Go();
            Console.WriteLine();

            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);
            boat.Go();
            Console.WriteLine();
        }
    }

    class Vehicle
    {
        public int speed = 0;
        public int wheels;
        public void Go()
        {
            Console.WriteLine("This vehicle is not moving!");
        }
    }

    class Car : Vehicle
    {
        public Car()
        {
            wheels = 4;
        }
    }

    class Bicycle : Vehicle
    {
        public Bicycle()
        {
            wheels = 2;
        }
    }

    class Boat : Vehicle
    {
        public Boat()
        {
            wheels = 0;
        }
    }
}
