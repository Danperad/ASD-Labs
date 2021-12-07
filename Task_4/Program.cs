using System;

namespace Task_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {1, 2, 3, 5, 7, 9, 10};
            Console.WriteLine("Неотсортированный массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            var temp = BubbleSort(arr);
            Console.WriteLine("Отсортированный массив методом пузырька: ");
            foreach (var t in temp)
            {
                Console.Write(t + " ");
            }
        }

        private static int[] BubbleSort(int[] mass)
        {
            int temp;
            int[] tempMass = (int[]) mass.Clone();
            int count = 0;
            int k = 0;
            for (int t = 0; t < tempMass.Length-1; t++)
            {
                if (tempMass[t] < tempMass[t+1])
                {
                    k++;
                }
            }
            if (k == tempMass.Length-1)
            {
                Console.WriteLine("\n\n Количество операций в методе пузырька: 1" );
                return tempMass;
            }
            for (int i = 0; i < tempMass.Length-1; i++)
            {
                if (tempMass[i] > tempMass[i + 1])
                {
                    temp = tempMass[i];
                    tempMass[i] = tempMass[i + 1];
                    tempMass[i + 1] = temp;
                }

                count += 4;
            }

            Console.WriteLine("\n\n Количество операций в методе пузырька: " + count);
            return tempMass;
        }
    }
}