using System;

namespace Task_6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {1, 2, 5, 4, 3};
            Console.WriteLine("Неотсортированный массив: ");
            foreach (var t in arr)
            {
                Console.Write(t + " ");
            }

            var temp = ShakerSort(arr);
            Console.WriteLine("\n Отсортированный массив: ");
            foreach (var t in temp)
            {
                Console.Write(t + " ");
            }

            Console.ReadKey();
        }

        private static int[] ShakerSort(int[] mass)
        {
            int count = 0;
            int[] temp = (int[]) mass.Clone();
            int k = 0;
            for (int t = 0; t < temp.Length-1; t++)
            {
                if (temp[t] < temp[t+1])
                {
                    k++;
                }
            }
            if (k == temp.Length-1)
            {
                Console.WriteLine("\n\n Количество операций: 1" );
                return temp;
            }
            for (int i = 0; i < temp.Length; i++)
            {
                count++;
                if (i % 2 == 0)
                {
                    for (int j = 0; j < temp.Length - i - 1; j++)
                    {
                        if (temp[j] > temp[j + 1])
                        {
                            Swap(ref temp[j], ref temp[j + 1]);
                        }
                    }
                }
                else
                {
                    for (int j = temp.Length - i - 1; j > 0; j--)
                    {
                        if (temp[j - 1] > temp[j])
                        {
                            Swap(ref temp[j], ref temp[j - 1]);
                        }
                    }
                }
            }

            Console.WriteLine("\n\n Количество операций: " + count);
            return temp;
        }
        private static void Swap(ref int e1, ref int e2)
        {
            (e1, e2) = (e2, e1);
        }
    }
}