using System;

namespace HomeTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            // потрібно було зробити 3 окремих консольних додатка
            AuthenticationIfElse();
            AuthenticationSwitch();
            AuthenticationSwitch();
        }
        public static void AuthenticationIfElse()
        {
            // тут молодець виніс в константу
            const string secretPassword = "12345";

            Console.WriteLine("Please, enter your login:");
            string loginInput = Console.ReadLine();

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
                    // супер, гарна логіка
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
        public static void AuthenticationTernary()
        {
            const string secretPassword = "12345";

            Console.WriteLine("Please, enter your login:");
            string loginInput = Console.ReadLine();

            if (loginInput == "USER")
            {
                Console.WriteLine("Please, enter your password:");
                string passwordInput = Console.ReadLine();
                // супер
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
        public static void AuthenticationSwitch()
        {
            const string secretPassword = "12345";

            Console.WriteLine("Please, enter your login:");
            string loginInput = Console.ReadLine();

            // супер
            switch(loginInput)
            {
                case "USER":
                    Console.WriteLine("Please, enter your password:");
                    string passwordInput = Console.ReadLine();
                    switch(passwordInput)
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
