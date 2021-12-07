using System;

namespace Task_3
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
                arr[i] = rnd.Next(-100, 100);
                Console.Write(arr[i] + " ");
            }
            int[] temp = InsertionSort(arr);
            Console.WriteLine("Отсортированный массив вставками: ");
            foreach (var t in temp)
            {
                Console.Write(t + " ");
            }
        }

        private static int[] InsertionSort(int[] mass)
        {
            int count = 0;
            int[] tempMass = (int[]) mass.Clone();
            for (int i = 1; i < tempMass.Length; i++)
            {
                var x = tempMass[i];
                var j = i;
                if(j % 2 == 0) continue;
                while (j > 1 && tempMass[j - 2] > x)
                {
                    Swap(ref tempMass[j], ref tempMass[j - 2]);
                    j -= 2;
                }
                tempMass[j] = x;
                count += 4;
            }
            Console.WriteLine("\n\n Количество операций в методе вставке: " + count);
            return tempMass;
        }

        private static void Swap(ref int e1, ref int e2)
        {
            (e1, e2) = (e2, e1);
        }
    }
}