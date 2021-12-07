using System;

namespace Task_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int x;
            Console.Write("Введите количество элементов массива: ");
            x = Convert.ToInt32(Console.ReadLine());
            var rnd = new Random();
            int[] mass = new int[x];
            for (int i = 0; i < x; i++)
                mass[i] = rnd.Next(0, 100);
            Console.WriteLine("Исходный массив: ");
            foreach (int i in mass)
            {
                Console.Write(i + " ");
            }
            int min = MinIndex(mass);
            Console.WriteLine("\n Минимальный элемент = " + mass[min] + ", его индекс = " + min);
        }
        
        private static int MinIndex(int[] mass, int i = 0, int min = 0)
        {
            if (i == mass.Length) return min;
            if (mass[i] < mass[min])
            {
                min = i;
            }
            min = MinIndex(mass, ++i, min);
            return min;
        }
    }
}