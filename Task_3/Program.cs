using System;

namespace Task_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var rnd = new Random();
            int x = 9;
            int[] mass = new int[x];
            for (int i = 0; i < x; i++)
                mass[i] = rnd.Next(0, 100);
            Console.WriteLine("Неотсортированный массив: ");
            foreach (int i in mass)
            {
                Console.Write(i + " ");
            }
            var temp = MergeSort(mass);
            Console.WriteLine("\n Массив после сортировки: ");
            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
        }

        private static int[] MergeSort(int[] mass)
        {
            int[] temp = (int[]) mass.Clone();
            int[] rightHalf = new int[temp.Length / 2];
            for (int i = 0; i < rightHalf.Length; i++) rightHalf[i] = temp[i];
            int[] leftHalf = new int[temp.Length - temp.Length / 2];
            for (int i = temp.Length / 2; i < temp.Length; i++) leftHalf[i - temp.Length / 2] = temp[i];
            if (rightHalf.Length > 1) rightHalf = MergeSort(rightHalf);
            if (leftHalf.Length > 1) leftHalf = MergeSort(leftHalf);
            int n = 0;
            int m = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                if (n < leftHalf.Length && m < rightHalf.Length)
                {
                    if (leftHalf[n] > rightHalf[m])
                    {
                        temp[i] = rightHalf[m];
                        m++;
                    }
                    else
                    {
                        temp[i] = leftHalf[n];
                        n++;
                    }
                }
                else
                {
                    if (n < leftHalf.Length)
                    {
                        for (; n < leftHalf.Length; n++, i++) temp[i] = leftHalf[n];
                        break;
                    }
                    if (m < rightHalf.Length)
                    {
                        for (; m < rightHalf.Length; m++, i++) temp[i] = rightHalf[m];
                        break;
                    }
                }
            }
            return temp;
        }
    }
}