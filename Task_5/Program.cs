using System;

namespace Task_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string str;
            int i;
            int j;
            Console.Write("Введите строку: ");
            str = Console.ReadLine();
            Console.Write("\n Введите индекс первого символа проверки на палиндром: ");
            i = int.Parse(Console.ReadLine());
            Console.Write("\n Введите индекс последнего символа проверки на палиндром: ");
            j = int.Parse(Console.ReadLine());
            Palindrom(str, i, j);
        }
        private static void Palindrom(string str, int i, int j)
        {
            int midIndex = (i + j) / 2;
            if (str[i] != str[j])
            {
                Console.WriteLine($"\n Фрагмент строки не является палиндромом");
                return;
            }
            if (i == midIndex || j == midIndex)
            {
                Console.WriteLine($"\n Фрагмент строки является палиндромом");
                return;
            }
            Palindrom(str, ++i, --j);
        }
    }
}