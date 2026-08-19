using System;

namespace My45thProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(400);

            car.Speed = 1000000000;

            Console.WriteLine(car.Speed);
        }
    }

    class Car
    {
        private int speed; // Encapsulate the field as private

        public Car(int speed)
        {
            Speed = speed;
        }

        public int Speed
        {
            get { return speed; } // Read
            set // Write
            {
                if (value > 500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
            }
        }
    }
}
