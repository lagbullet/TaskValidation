using System;

namespace ValidationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Validator validator = new Validator();
            string email = Console.ReadLine();
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
