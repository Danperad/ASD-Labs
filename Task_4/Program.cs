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
            Console.WriteLine($"Наибольший общий делитель {a} и {b} = " + Nod(a, b));
        }
        
        private static long Nod(long a, long b)
        {
            if (a == 0) return b;
            if (b == 0) return a;
            if (a > b) return Nod(b, a % b);
            if (a < b) return Nod(a, b % a);
            if (a == b) return b;
            return 1;
        }
    }
}