using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "admin";
            string password = "pass1234";

            string userName, userPassword;

            Console.WriteLine("Enter your username =>");
            userName = Console.ReadLine();
            Console.WriteLine("Enter your password =>");
            userPassword = Console.ReadLine();

            if (login == userName && password == userPassword)
                Console.WriteLine("Welcome!");
            else
                Console.WriteLine("Ooops.Something went wrong.");
        }
    }
}
