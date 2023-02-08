using System;

namespace AuthenticationSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            const string secretPassword = "12345";

            Console.WriteLine("Please, enter your login:");
            string loginInput = Console.ReadLine();

            switch (loginInput)
            {
                case "USER":
                    Console.WriteLine("Please, enter your password:");
                    string passwordInput = Console.ReadLine();
                    switch (passwordInput)
                    {
                        case secretPassword:
                            Console.WriteLine("Hello User!");
                            break;
                        default:
                            Console.WriteLine("Password is not correct");
                            break;
                    }
                    break;

                case "ADMIN":
                    Console.WriteLine("Please, enter your password:");
                    passwordInput = Console.ReadLine();
                    switch (passwordInput)
                    {
                        case secretPassword:
                            Console.WriteLine("Hello Administrator!");
                            break;
                        default:
                            Console.WriteLine("Password is not correct");
                            break;
                    }
                    break;

                case "":
                    Console.WriteLine("Hello Anonimous!");
                    break;
                default:
                    break;
            }
        }
    }
}
