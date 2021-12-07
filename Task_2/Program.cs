using System;

namespace Task_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            bool proverka = IsCoprimeNumbers(a, b);
            if (proverka) Console.WriteLine($"Числа {a} и {b} взаимно простые");
            else Console.WriteLine($"Числа {a} и {b} не являются взаимно простыми");
        }

        private static bool IsCoprimeNumbers(int a, int b)
        {
            return Nod(a, b) == 1;
        }

        private static long Nod(long a, long b)
        {
            if (a == 0) return b;
            if (b == 0) return a;
            if (a > b) return Nod(b, a % b);
            if (a < b) return Nod(a, b % a);
            if (a == b) return a;
            return 1;
        }
    }
}