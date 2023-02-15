using System;

namespace HomeTask5
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i < 5; i++)
            { 
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }                   
                for (int j = 1; j < i * 2; j++)
                {
                    Console.Write("*");
                }                   
                Console.WriteLine();
            }

            for (int i = 5; i > 0; i--)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < i * 2; j++)
                {
                    Console.Write("*");
                }                   
                Console.WriteLine();
            }

        }
    }
}
