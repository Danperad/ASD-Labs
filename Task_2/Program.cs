using System;

namespace Task_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            const int n = 20;
            int[] A = new int[n], B = new int[n], C = new int[n];
            Console.WriteLine($"Введите {n} чисел для массива A");
            for (int i = 0; i < n; i++)
            {
                A[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Введите {n} чисел для массива B");
            for (int i = 0; i < n; i++)
            {
                B[i] = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                C[i] = Math.Min(A[i], B[i]);
            }
            foreach (var i in C)
            {
                Console.Write($"{i} ");
            }

            Console.ReadKey();
        }
    }
}