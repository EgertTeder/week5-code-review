using System;

namespace LoginCredentials
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Login Form
             * login: user
             * password: user1234
             * Create a program that asks user's login credentials
             * Check if the user entered correct login and password
             * If the login and password are correct display 'Welcome'
             * If the login or password are incorrect dispay 'try again'
             
             */
            
            
            Console.WriteLine("Enter your login credentials:");
            string UserName = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            if (UserName == "admin" password == "admin1234")
            {
                Console.WriteLine("Welcome!");
            }
            else if
            {
                Console.WriteLine("The password or login credential is incorrect. Try again!");
            }
            
            else if (UserName !== "admin" || password !== "admin1234")
            {
                Console.WriteLine("Incorrect login credentials or password. Try again!");
            }
            else 
            {
                Console.WriteLine("Success!");
            }
        }
    }
}
