using System;

namespace Task_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите V и x");
            double V = Double.Parse(Console.ReadLine()), S = 0;
            double x = Double.Parse(Console.ReadLine());
            ulong r;
            int n = 0;
            do
            {
                r = 1;
                n++;
                for (int i = 1; i <= n + 2; i++) r *= (ulong) i;
                double a = x * (n + 1.0) / r;
                S = S + a;
            } while (S <= V);
            Console.WriteLine($"{n}");
            Console.ReadLine();
        }
    }
}