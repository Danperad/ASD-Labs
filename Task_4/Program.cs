using System;

namespace Task_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Наибольший общий делитель вариантом алгоритма Евклида для {a} и {b} = " +
                              EvklidNod(a, b));
        }

        private static long EvklidNod(long a, long b)
        {
            if (a == 0) return b;
            if (b % 2 == 0 && a % 2 == 0) return 2 * EvklidNod(a / 2, b / 2);
            if (a % 2 == 0) return EvklidNod(a / 2, b);
            if (b > a) return EvklidNod(b - a, a);
            return EvklidNod(a - b, b);
        }
    }
}