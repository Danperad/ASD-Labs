using System;

namespace Task_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rnd = new Random();
            Console.WriteLine("Неотсортированный массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-100, 100);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Быстрая сортировка: ");
            QuickSort(arr, 0, 9);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
        private static int[] QuickSort(int[] a, int i, int j)
        {
            if (i < j)
            {
                int q = Partition(a, i, j);
                a = QuickSort(a, i, q);
                a = QuickSort(a, q + 1, j);
            }

            return a;
        }

        private static int Partition(int[] a, int p, int r)
        {
            int x = a[p];
            int i = p - 1;
            int j = r + 1;
            while (true)
            {
                do
                {
                    j--;
                }
                while (a[j] > x);
                do
                {
                    i++;
                }
                while (a[i] < x);
                if (i < j)
                {
                    (a[i], a[j]) = (a[j], a[i]);
                }
                else
                {
                    return j;
                }
            }
        }
    }
}