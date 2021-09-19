using System;

namespace Task_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            const int n = 20;
            int[] A = new int[n], B = new int[n], C = new int[n];
            var rand = new Random();
            Console.WriteLine("Массив A");
            for (int i = 0; i < n; i++)
            {
                A[i] = rand.Next(-10,50);
                Console.Write($"{A[i]} ");
            }
            Console.WriteLine(Environment.NewLine + "Массив B");
            for (int i = 0; i < n; i++)
            {
                B[i] = rand.Next(-10,50);
                Console.Write($"{B[i]} ");
            }
            Console.WriteLine(Environment.NewLine + "Массив C");
            for (int i = 0; i < n; i++)
            {
                C[i] = Math.Min(A[i], B[i]);
                Console.Write($"{C[i]} ");
            }

            Console.ReadKey();
        }
    }
}