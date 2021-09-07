using System;

namespace Task_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a, b, max = 1;
            Console.WriteLine("Введите 2 числа");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            for (int i = 2; i <= Math.Min(a, b); i++)
            {
                if (a % i == 0 && b % i == 0) max = i;
            }
            Console.WriteLine($"НОД для {a} и {b} - {max}");
            Console.ReadKey();
        }
    }
}