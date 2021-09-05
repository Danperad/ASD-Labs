using System;

namespace ASD
{
    class Program
    {
        public static void Main(string[] args)
        {
            double a = 2, b = 0.5, x, Y, F;
            Console.Write("Введите x... ");
            x = Double.Parse(Console.ReadLine());
            Y = Math.Pow(x, 2) * (Math.Pow(Math.Atan(a * x + b), 2) - Math.Sqrt(Math.Abs(Math.Pow(x - a, 2) - b)));
            F = Math.Sqrt(a * Math.Pow(x, 2) + b + x) - Math.Pow(Math.E, -a + x) + a * x * Math.Log(x + a - 5);
            Console.WriteLine($"Y = {Y}, F = {F}");
            Console.ReadLine();
        }
    }
}