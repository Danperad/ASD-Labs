using System;

namespace Task_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {7, 1, 2, 8, 6, 9, 4};
            Console.WriteLine("Неотсортированный массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            var temp = BubbleSortMod(arr);
            Console.WriteLine("Отсортированный массив: ");
            foreach (var t in temp)
            {
                Console.Write(t + " ");
            }
        }

        static int[] BubbleSortMod(int[] mass)
        {
            int count = 0;
            int[] temp = (int[]) mass.Clone();
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
            Console.WriteLine("\n\n Количество операций в методе пузырька: " + count);
            return temp;
        }

        private static void Swap(ref int e1, ref int e2)
        {
            (e1, e2) = (e2, e1);
        }
    }
}