using System;

namespace Task_8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var rnd = new Random();
            Console.WriteLine("Введите кол-во элементов массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[n];
            Console.WriteLine("Массив: ");
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(-100, 100);
                Console.Write(mass[i] + " ");
            }
            Console.WriteLine("\n Минимальный элемент массива: " + Min(mass, n));
            Console.ReadKey();
        }
        private static int Min(int[] a, int n)
        {
            if (n <= 1) return a[0];
            if (n > a.Length) n = a.Length;
            return Math.Min(a[n - 1], Min(a, n - 1));
        }
    }
}