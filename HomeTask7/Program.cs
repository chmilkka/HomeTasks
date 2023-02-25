using System;

namespace HomeTask7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть число вiд 1 до n:");
            int intArg = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сума чисел вiд 1 до {intArg} = {SumTo(intArg)}");

            Console.WriteLine("Введiть два цiлих числа:");
            int intArg1 = int.Parse(Console.ReadLine());
            int intArg2 = int.Parse(Console.ReadLine());
            Add(intArg1, intArg2); // Перевантаження 1

            Console.WriteLine("Введiть два дробових числа:");
            double doubleArg1 = double.Parse(Console.ReadLine());
            double doubleArg2 = double.Parse(Console.ReadLine());
            Add(doubleArg1, doubleArg2); // Перевантаження 2

            Console.WriteLine("Введiть два цiлих числа:");
            string stringArg1 = Console.ReadLine();
            string stringArg2 = Console.ReadLine();
            Add(stringArg1, stringArg2); // Перевантаження 3
        }
        static int SumTo(int arg)
        {
            if (arg <= 0)
            {
                Console.WriteLine("Неприпустиме значення аргументу"); 
                return -1; // Обрав значення -1 як помилку для мінусового значення аргументу.
                           // Хоча можно зробити цю умову у мєйні, але завдання було створити метод, тому і логіку додав сюди                         
            }
            else if(arg == 1)
            {
                return 1;
            }
            return arg + SumTo(arg - 1);
        }
        static void Add(int a, int b)
        {
            Console.WriteLine($"Сума {a} та {b} = {a + b}");
        }
        static void Add(double a, double b)
        {
            Console.WriteLine($"Сума {a} та {b} = {a + b}");
        }
        static void Add(string a, string b)
        {
            Console.WriteLine($"Сума {a} та {b} = {int.Parse(a) + int.Parse(b)}"); 
            // Якщо потрібно розрахувати суму чисел, тоді доречно ці рядки зпарсити.                                                                                                       
            // Інакше відбувається конкатенація рядків.
        }
    }
}
