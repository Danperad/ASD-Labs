using System;

namespace Task_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            const int n = 11;
            int[] A = new int[n];
            Console.WriteLine($"Введите {n} чисел");
            for (int i = 0; i < n; i++)
            {
                A[i] = Int32.Parse(Console.ReadLine());
            }
            int min = Int32.MaxValue,minI = -1, max = Int32.MinValue, maxI = -1;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                    maxI = i;
                }
                if (A[i] < min)
                {
                    min = A[i];
                    minI = i;
                }
            }
            if (minI != -1) A[minI] = -1;
            if (maxI != -1) A[maxI] = 1;
            foreach (var i in A)
            {
                Console.Write($"{i} ");
            }

            Console.ReadKey();
        }
    }
}