using System;

namespace Task_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[,] R = new int[6, 6];
            int[] M = new int[6];
            Console.WriteLine("Введите два числа");
            int K1 = Int32.Parse(Console.ReadLine());
            int K2 = Int32.Parse(Console.ReadLine());
            var rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    R[i, j] = rand.Next(10000);
                }
            }

            for (int i = 0; i < 6; i++)
            {
                if (R[i, 5 - i] >= K2 && R[i, 5 - i] <= K1) M[i] = R[i, 5 - i];
            }

            foreach (var i in M)
            {
                Console.Write($"{i} ");
            }

            Console.ReadKey();
        }
    }
}