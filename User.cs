// create a class for user data (login, password)

using System;

namespace login
{
    class User
    {

        //create two arrays for login and password
        List<string> logins = new List<string>();
        List<string> passwords = new List<string>();

        public static void Login()
        {
            Console.WriteLine("Enter your login:");
            string login = Console.ReadLine();

            // check if login is registered
            // if yes -> get the index of the login
            // if no -> ask if the user wants to register

            int index = logins.IndexOf(login);
            if (index == -1)
            {
                Console.WriteLine("This login is not registered!");
                Console.WriteLine("Do you want to register?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    User.Register();
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid choice!");
                }
            } 

            else
            {
                // check if password is correct
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Enter your password:");
                    string password = Console.ReadLine();
                    
                    if (passwords[index] == password)
                    {
                        Console.WriteLine("You have successfully logged in!");
                    }

                    else
                    {
                        Console.WriteLine("Wrong password!");
                        Console.WriteLine($"{2 - i} attempts left!");
                    }
                }
            }

            // check if login and password are correct

        }

        public static void Register()
        {
            Console.WriteLine("Enter your login:");
            string login = Console.ReadLine();

            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            // check if login is already taken
            if (logins.Contains(login))
            {
                Console.WriteLine("This login is already taken!");
            }

            else
            {
                logins.Add(login);
                passwords.Add(password);
                Console.WriteLine("You have successfully registered!");
            }
        }
    }
}
