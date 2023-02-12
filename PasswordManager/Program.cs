using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace PasswordManager
{
    class Program
    {
        static Dictionary<string, string> passwords = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Password Manager");
            Console.WriteLine("1. Add Password");
            Console.WriteLine("2. View Password");
            Console.WriteLine("3. Quit");

            int option = Convert.ToInt32(Console.ReadLine());

            while (option != 3)
            {
                switch (option)
                {
                    case 1:
                        AddPassword();
                        break;
                    case 2:
                        ViewPassword();
                        break;
                }

                Console.WriteLine("Password Manager");
                Console.WriteLine("1. Add Password");
                Console.WriteLine("2. View Password");
                Console.WriteLine("3. Quit");

                option = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void AddPassword()
        {
            Console.WriteLine("Enter the name of the website or service: ");
            string website = Console.ReadLine();

            Console.WriteLine("Enter the password: ");
            string password = Console.ReadLine();

            string hashedPassword = HashPassword(password);

            passwords.Add(website, hashedPassword);

            Console.WriteLine("Password added successfully.");
        }

        static void ViewPassword()
        {
            Console.WriteLine("Enter the name of the website or service: ");
            string website = Console.ReadLine();

            if (passwords.ContainsKey(website))
            {
                Console.WriteLine("Password: " + passwords[website]);
            }
            else
            {
                Console.WriteLine("Website not found.");
            }
        }

        static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                return Convert.ToBase64String(hash);
            }
        }
    }
}
