using System;

namespace Task_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите количество чисел: ");
            int lenght = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[lenght];
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"Введите {i} элемент: ");
                mass[i] = Convert.ToInt32(Console.ReadLine());
            }
            reverce(mass);
            Console.ReadKey();
        }
        private static void reverce(int[] mass, int x = 0)
        {
            if (x != mass.Length)
            {
                reverce(mass, x + 1);
                Console.Write(mass[x] + " ");
            }
        }
    }
}