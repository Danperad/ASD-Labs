using System;

namespace Task_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите V");
            double V = Double.Parse(Console.ReadLine()), S = 0, x = 10;
            ulong n = 0, r;
            do
            {
                r = 1;
                n++;
                for (ulong i = 1; i <= n + 2; i++) r *= i;
                x = x * (n + 1.0) / r;
                S = S + x;
            } while (S < V);
            Console.WriteLine($"{n}");
            Console.ReadLine();
        }
    }
}