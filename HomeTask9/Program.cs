using System;
using System.Text;

namespace HomeTask9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            string text = Console.ReadLine();
            CountOfSentence(text);
            CountOfNames(text);          
        }
        static void CountOfSentence(string text)
        {
            string[] str = text.Split('.', '!', '?', '…');
            int counter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != "")
                {
                    counter++;
                }
            }
            Console.WriteLine($"Кількість речень: {counter}");
        }
        static void CountOfNames(string text)
        {
            string temp = "";
            char[] str = text.ToCharArray();

            //Ідея: розділив весь текст на массив символів, якщо зустрічається велика буква,
            //і за дві позиції до неї не стоїть пунктуаційний знак то це ім'я
            for (int i = 2; i < str.Length; i++)
            {
                if (str[i].ToString() == str[i].ToString().ToUpper() && Char.IsLetter(str[i]))
                {
                    if (str[i - 2] != '.' && str[i - 2] != '!' && str[i - 2] != '…' && str[i - 2] != '?')
                    {
                        for (int j = i; Char.IsLetter(str[j]); j++)
                        {                           
                            temp += str[j];        //Збираю імена у строку               
                        }
                        temp += ", ";
                    }
                }
            }

            
            string[] result = temp.Split(" ");          
            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] != "" && result[i] == result[j])
                    {
                        result[i] = "";    //Імена які повторюються замінюю на пробіл                   
                    }
                }
            }

            //Лічильник унікальних імен
            int counter = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != "")
                {
                    counter++;
                }
            }
            Console.WriteLine($"Кількість унікальних імен або прізвищ: {counter}");

            //Вивід масиву імен у консоль
            Console.Write("Унікальних імена та прізвища: ");
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != "")
                {
                    Console.Write(result[i] + " ");
                }
            }
        }
    }
}
