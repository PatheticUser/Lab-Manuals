using System;
using System.Collections.Generic;

namespace UserValidationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Predefined users (username, password)
            Dictionary<string, string> users = new Dictionary<string, string>()
            {
                { "Rameez", "PU0000" },
                { "fatima99", "secure99" },
                { "ali2025", "pakistan" }
            };

            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            // Check if user exists and password matches
            if (users.ContainsKey(username) && users[username] == password)
            {
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine("Invalid username or password. Access denied.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
