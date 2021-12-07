using System;

namespace Task_10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int N = 10;
            int groups = (int) Math.Round(Math.Sqrt(N));
            var r = new Random();
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = r.Next(-100, 100);
            }

            int[][] W = new int[groups][];
            int count = 0;
            for (int i = 0; i < groups; i++)
            {
                int n = N / groups;
                if (i < N % groups)
                {
                    n++;
                }

                W[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    W[i][j] = A[j + count];
                }

                count += n;
            }

            int[] B = new int[groups];
            for (int i = 0; i < groups; i++)
            {
                B[i] = Min(W[i]);
            }

            int[] C = new int[N];
            for (int i = 0; i < N; i++)
            {
                int index = MinIndex(B);
                C[i] = B[index];
                B[index] = Min(W[index]);
            }

            Console.WriteLine("Неотсортированный массив: ");
            Console.WriteLine(string.Join(" ", A));
            Console.WriteLine("Отсортированный массив:");
            Console.WriteLine(string.Join(" ", C));
        }

        private static int Min(int[] array)
        {
            int index = MinIndex(array);
            int min = array[index];
            array[index] = int.MaxValue;
            return min;
        }

        private static int MinIndex(int[] array)
        {
            int min = array[0];
            int index = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    index = i;
                }
            }

            return index;
        }
    }
}