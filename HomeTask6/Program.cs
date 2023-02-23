using System;

namespace HomeTask6
{
    class Program
    {
        static void Main(string[] args)
        {           
            double result;

            while (true)
            {                                          
                Console.WriteLine("Введiть число А:");
                double a = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Введiть число В:");
                double b = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Оберiть дiю:");
                Console.WriteLine("+");
                Console.WriteLine("-");
                Console.WriteLine("/");
                Console.WriteLine("*");
                Console.WriteLine("^");

                string input = Console.ReadLine();
                Console.Clear();

                switch (input)
                {
                    case "+":
                        result = Sum(a, b);
                        Console.WriteLine($"{a} + {b} = {result}");
                        break;
                    case "-":
                        result = Difference(a, b);
                        Console.WriteLine($"{a} - {b} = {result}");
                        break;
                    case "/":
                        if (b == 0)
                        {
                            Console.WriteLine("Дiлення на нуль неможливе!");
                            break;
                        }
                        else
                        {
                            result = Division(a, b);
                            Console.WriteLine($"{a} / {b} = {result}");
                            break;
                        }
                    case "*":
                        result = Multiplication(a, b);
                        Console.WriteLine($"{a} * {b} = {result}");
                        break;
                    case "^":
                        result = Square(a, b);
                        Console.WriteLine($"{a} ^ {b} = {result}");
                        break;
                    default:
                        Console.WriteLine("Обрана неiснуюча дiя!");
                        break;
                }              

                Console.WriteLine("Продовжити роботу калькулятора?(+/-)");
                string input1 = Console.ReadLine();

                if (input1 == "+")
                {
                    Console.Clear();
                    continue;
                }
                if (input1 == "-")
                {
                    Console.Clear();
                    break;
                }
                Console.Clear();
            }
            Console.WriteLine("Калькулятор завершив роботу!");
        }
        static double Sum(double arg1, double arg2)
        {
            return arg1 + arg2;
        }
        static double Difference(double arg1, double arg2)
        {
            return arg1 - arg2;
        }
        static double Division(double arg1, double arg2)
        {
            return arg1 / arg2;
        }
        static double Multiplication(double arg1, double arg2)
        {
            return arg1 * arg2;
        }
        static double Square(double arg1, double arg2)
        {
            double result = 1;
            for (int i = 0; i < arg2; i++)
            {
                result *= arg1;
            }
            return result;
        }
    }
}
