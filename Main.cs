using System;

namespace login
{
    class Main
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Login System v0.1!");
            Console.WriteLine("Do you want to login or register?");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                User.Login();
            }
            else if (choice == "2")
            {
                User.Register();
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
        }
    }

}