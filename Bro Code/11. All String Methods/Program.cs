using System;

namespace My10ThProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //STRING MEDTHODS - NOT ALL OF THEM


            String fullName = "Bro Code";
            String phoneNumber = "123-456-7890";

            //fullName = fullName.ToUpper();
            //fullName = fullName.ToLower();

            //Console.WriteLine(fullName);

            //phoneNumber = phoneNumber.Replace("-", "/");
            //Console.WriteLine(phoneNumber);

            //String userName = fullName.Insert(0, "@");
            //Console.WriteLine(userName);

            Console.WriteLine(fullName.Length);

            String firstName = fullName.Substring(0, 3);
            String lastName = fullName.Substring(3);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
        }
    }
}