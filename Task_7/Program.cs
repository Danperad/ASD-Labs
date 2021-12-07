using System;

namespace Task_7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 0, 3, 7, 2, 6, 9, 1, 4, 5 };
            Console.WriteLine("Неотсортированный массив: ");
            foreach (var t in array)
            {
                Console.Write(t + " ");
            }
            Console.WriteLine("\n Отсортированный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[0] = array[i];
                var j = i;
                while (j > 1 && array[j - 1] > array[0])
                {
                    (array[j - 1], array[j]) = (array[j], array[j - 1]);
                    j--;
                }
                array[j] = array[0];
            }
            foreach (var t in array)
            {
                Console.Write(t + " ");
            }
            Console.ReadLine();
        }
    }
}