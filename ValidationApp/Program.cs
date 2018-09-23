using System;

namespace ValidationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            Validator validator = new Validator();
            if (validator.IsValidEmail(email))
                Console.WriteLine("Email is valid");
            else
                Console.WriteLine("Email is invalid");
            string url = Console.ReadLine();
            if (validator.IsValidURL(url))
                Console.WriteLine("URL is correct");
            else
                Console.WriteLine("URL is incorrect");
            string filepath = Console.ReadLine();
            if (validator.IsValidFilePath(filepath))
                Console.WriteLine("File path is correct");
            else
                Console.WriteLine("File path is incorrect");
            Console.ReadLine();
        }
    }
}
