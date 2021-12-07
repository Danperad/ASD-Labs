using System;

namespace Task_8
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
                arr[i] = rnd.Next(-10, 10);
                Console.Write(arr[i] + " ");
            }
            var temp = BinarySort(arr);
            Console.WriteLine("\n Отсортированный массив: ");
            foreach (var t in temp)
            {
                Console.Write(t + " ");
            }
        }
        private static int[] BinarySort(int[] mass)
        {
            int[] temp = (int[]) mass.Clone();
            for (int i = 1; i < temp.Length; i++)
            {
                int x = temp[i];
                int j;
                if (x < temp[i / 2])
                {
                    for (j = i; j > 0 && x < temp[j - 1]; j--)
                    {
                        temp[j] = temp[j - 1];
                    }
                }
                else
                {
                    for (j = i; j >= i / 2 && x < temp[j - 1]; j--)
                    {
                        temp[j] = temp[j - 1];
                    }
                }
                temp[j] = x;
            }

            return temp;
        }
    }
}