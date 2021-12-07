using System;

namespace Task_7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{x} число фибоначи: " + Fibonachi(x));
            Console.ReadKey();
        }

        private static int Fibonachi(int x)
        {
            if (x == 0) return 0;
            if (x == 1) return 1;
            return Fibonachi(x - 1) + Fibonachi(x - 2);
        }
    }
}