using System;

namespace Task_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите а1: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите коэфициент d: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер члена прогресии: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{number} равен = {Calculate(a1, d, number)}");
            Console.ReadKey();
        }
        static int Calculate(int a1, int d, int number)
        {
            if (number == 1) return a1;
            return Calculate(a1 + d, d, number - 1);
        }
    }
}