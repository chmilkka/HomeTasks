using System;

namespace HomeTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte humanAge = 19; // Якщо говорити про вік людей то доречно використати byte
            double bankAccount = 999999999999.99; // Використовую double бо до цілого числа(грн) можуть додаватися копійки,
                                                  // але сумніваюся, бо у банківських розрахунках доречніше використовувати decimal
                                                  // для більшої точності значень 
            char letter = 'A';
            string message = "Hello World";
            bool assessment = false; // Я вважаю що сусід сказав неправдиву інформацію щодо тривалості життя людини
            float humanTemperature = 36.6f; // float займає менше пам'яті ніж інші типи даних з плавучою крапкою
            long planetPopulation = 8014863147; // Приблизне населення нашої планети зараз
            sbyte temperatureInUkraine = -3; // На мою думку доречно використовувати тип даних
                                             // який працює з цілими числами у невеликому діапазоні

            Console.WriteLine($"Age: {humanAge}");
            Console.WriteLine($"Bank account: {bankAccount}");
            Console.WriteLine($"Letter: {letter}");
            Console.WriteLine($"Message: {message}");
            Console.WriteLine($"True or false: {assessment}");
            Console.WriteLine($"Normal human temperature: {humanTemperature}");
            Console.WriteLine($"Planet population: {planetPopulation}");
            Console.WriteLine($"Temperature in Ukraine: {temperatureInUkraine}");
        }
    }
}
