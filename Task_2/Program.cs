using System;

namespace Task_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] K = new int[8, 4];
            Console.WriteLine("Введите число");
            int H = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            var rand = new Random();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    K[i, j] = rand.Next(10000);
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (((i + 1) % 2) != 0) continue;
                for (int j = 0; j < 4; j++)
                {
                    K[i, j] = H;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{K[i,j]} ");
                }

                Console.Write(Environment.NewLine);
            }
            Console.ReadKey();
        }
    }
}