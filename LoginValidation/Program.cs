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
            int shet = 0;
            while (shet!=3)
            {
                Console.WriteLine("Enter your username =>");
                userName = Console.ReadLine();
                Console.WriteLine("Enter your password =>");
                userPassword = Console.ReadLine();

                if (login != userName || password != userPassword)
            {
                    Console.WriteLine("Ooops.Something went wrong.");
                    shet++;
                    Console.WriteLine($"{3 - shet} attempts left");
            }
                    
                else
            {
                    Console.WriteLine("Welcome!");
                    break;
            }
            }
               
                    
        }
    }
}
