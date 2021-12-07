using System;

namespace Task_6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите количество членов арифметической прогрессии n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите первый членов арифметической прогрессии а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите разность арифметической прогрессии d: ");
            int d = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int temp = a;
            Recyrsion(n, ref temp, d, ref sum);
            Console.WriteLine($"Сумма первых {n} членов ряда при разность арифметической прогрессии d = {d} и первом члене ряда а = {a} будет равняться {sum}");
            Console.ReadLine();
        }
        private static void Recyrsion(int n, ref int a, int d, ref int sum)
        {
            if (n > 0) sum += a;
            if (n == 1) return;
            a += d;
            Recyrsion(n - 1, ref a, d, ref sum);
        }
    }
}