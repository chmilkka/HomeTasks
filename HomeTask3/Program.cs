using System;

namespace HomeTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            const string secretPassword = "12345";

            Console.WriteLine("Please, enter your login:");
            string loginInput = Console.ReadLine();
// теж можна було в константу
            if (loginInput == "USER")
            {
                Console.WriteLine("Please, enter your password:");
                string passwordInput = Console.ReadLine();
                if (passwordInput == secretPassword)
                {
                    Console.WriteLine("Hello User!");
                }
                else
                {
                    Console.WriteLine("Password is not correct");
                }
            }
            else if (loginInput == "ADMIN")
            {
                Console.WriteLine("Please, enter your password:");
                string passwordInput = Console.ReadLine();
                if (passwordInput == secretPassword)
                {
                    Console.WriteLine("Hello Administrator!");
                }
                else
                {
                    Console.WriteLine("Password is not correct");
                }
            }
            else if (loginInput == "")
            {
                Console.WriteLine("Hello Anonimous!");
            }
        }         
    }
}
