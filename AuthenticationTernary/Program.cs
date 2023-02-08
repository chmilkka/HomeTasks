using System;

namespace AuthenticationTernary
{
    class Program
    {
        static void Main(string[] args)
        {
            const string secretPassword = "12345";

            Console.WriteLine("Please, enter your login:");
            string loginInput = Console.ReadLine();

            if (loginInput == "USER")
            {
                Console.WriteLine("Please, enter your password:");
                string passwordInput = Console.ReadLine();
                string message = passwordInput == secretPassword ? "Hello User!" : "Password is not correct";
                Console.WriteLine(message);
            }
            else if (loginInput == "ADMIN")
            {
                Console.WriteLine("Please, enter your password:");
                string passwordInput = Console.ReadLine();
                string message = passwordInput == secretPassword ? "Hello Administrator!" : "Password is not correct";
                Console.WriteLine(message);
            }
            else if (loginInput == "")
            {
                Console.WriteLine("Hello Anonimous!");
            }
        }
    }
}
