using System;

namespace Task_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Генерация массивов
            int[] A = new int[20];
            int[,] B = new int[3, 3];
            var rand = new Random();
            int n = 0;
            for (int i = 0; i < 20; i++)
            {
                A[i] = rand.Next(-10, 20);
                if (A[i] < 5 && A[i] > -3) n++;
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    B[i, j] = rand.Next(-10, 20);
                    if (B[i, j] < 5 && B[i, j] > -3) n++;
                }
            }
            
            // Вывод массивов
            int[] R = new int[n];
            int index = 0;
            Console.WriteLine("Массив A");
            foreach (int num in A)
            {
                if (num < 5 && num > -3)
                {
                    R[index] = num;
                    index++;
                }
                Console.Write(num + " ");
            }
            Console.WriteLine(Environment.NewLine +"Массив B");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (B[i,j] < 5 && B[i,j] > -3)
                    {
                        R[index] = B[i,j];
                        index++;
                    }
                    Console.Write(B[i,j] + " ");
                }
                Console.WriteLine();
            }

            // Сортировка массива
            int temp;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (R[i] > R[j])
                    {
                        temp = R[i];
                        R[i] = R[j];
                        R[j] = temp;
                    }
                }
            }
            Console.WriteLine("Отсортированный массив");
            foreach (var num in R)
            {
                Console.Write(num + " ");
            }

            Console.ReadKey();
        }
    }
}