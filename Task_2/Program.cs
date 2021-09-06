using System;

namespace Task_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int pol = 1, otr = 1;
            int[] x = new int[3];
            Console.WriteLine("Введите 3 числа");
            x[0] = Int32.Parse(Console.ReadLine());
            x[1] = Int32.Parse(Console.ReadLine());
            x[2] = Int32.Parse(Console.ReadLine());
            if (x[0] >= 0) pol *= x[0];
            else otr *= x[0];
            if (x[1] >= 0) pol *= x[1];
            else otr *= x[1];
            if (x[2] >= 0) pol *= x[2];
            else otr *= x[2];
            Console.WriteLine($"Произведение положительных {pol}, отрицательных {otr}");
            Console.ReadKey();
        }
    }
}