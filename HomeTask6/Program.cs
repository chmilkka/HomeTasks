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
                Console.WriteLine("1.Додавання");
                Console.WriteLine("2.Вiднiмання");
                Console.WriteLine("3.Дiлення");
                Console.WriteLine("4.Множення");

                int input = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (input)
                {
                    case 1:
                        result = Sum(a, b);
                        Console.WriteLine($"{a} + {b} = {result}");
                        break;
                    case 2:
                        result = Difference(a, b);
                        Console.WriteLine($"{a} - {b} = {result}");
                        break;
                    case 3:
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
                    case 4:
                        result = Multiplication(a, b);
                        Console.WriteLine($"{a} * {b} = {result}");
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
    }
}
