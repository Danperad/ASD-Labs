using System;

namespace Task_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Наибольшее общее кратное {a} и {b} = " + Nok(a, b));
            Console.ReadLine();
        }

        private static int Nod(int a, int b)
        {
            if (a == 0) return b;
            if (b == 0) return a;
            if (a > b) return Nod(b, a % b);
            if (a < b) return Nod(a, b % a);
            if (a == b) return a;
            return 1;
        }

        private static long Nok(int a, int b)
        {
            return a * b / Nod(a, b);
        }
    }
}