using System;

namespace HomeTask8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = new string[5, 9]; //Пробіл не враховується за char(char s = " ";) не працює,
                                                //тому використав масив string, але ж працював як з масивом char,
                                                //тому сподіваюся що це не порушення обмежень
            array = FillArray(array);
            array = ArrayModify(array);
            DrawArray(array);
        }
        static string[,] FillArray(string[,] array)
        {
            //Заповнення всієї матриці зірочками
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    array[i, j] = "*";
                }
            }
            return array;
        }
        static string[,] ArrayModify(string[,] array)
        {
            //Зміна зірочок на пробіли у лівій верхній частині матриці
            for (int j = 0; j < 9; j++)
            {
                for (int i = 0; i < 4 - j; i++)
                {
                    array[i, j] = " ";
                }
            }

            //Зміна зірочок на пробіли у правій верхній частині матриці
            int counter = 0;
            for (int j = 8; j >= 0; j--)
            {
                counter++;
                for (int i = 0; i < 5 - counter; i++)
                {
                    array[i, j] = " ";
                }
            }
            return array;
        }
        static void DrawArray(string[,] array)
        {
            //Відмальовування готової матриці у консоль
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
