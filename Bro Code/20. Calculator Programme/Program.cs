using System;

namespace My19thProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                double num1 = 0;
                double num2 = 0;

                double result = 0;

                Console.WriteLine("----------------------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("----------------------------------");

                Console.WriteLine("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter number 1: ");
                num2 = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter an option: ");
                Console.WriteLine("+ : Add");
                Console.WriteLine("- : Subtract");
                Console.WriteLine("* : Multiply");
                Console.WriteLine("/ : Divide");
                Console.WriteLine("Enter an option");


                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = {result}");
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = {result}");
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = {result}");
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = {result}");
                        break;
                }
                Console.WriteLine("Would you like to continue? (Y/N)");

            } while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Bye");

        }
    }
}