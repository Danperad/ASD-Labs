using System;

namespace Task_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень: ");
            int pow = Convert.ToInt32(Console.ReadLine());
            while (pow < 0)
            {
                Console.WriteLine("Введите неотрицательно число");
                pow = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(x + " в степени " + pow + " = " + Degree(x, pow));
            Console.ReadKey();
        }
        private static int Degree(int x, int pow)
        {
            if (pow == 0) return 1;
            return Degree(x, pow - 1) * x;
        }
    }
}