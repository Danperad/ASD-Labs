using System;

namespace Task_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var rnd = new Random();
            int x = 5;
            int[] mass1 = new int[x];
            for (int i = 0; i < mass1.Length; i++)
                mass1[i] = rnd.Next(0, 100);
            int[] mass2 = new int[x];
            for (int i = 0; i < mass2.Length; i++)
                mass2[i] = rnd.Next(0, 100);
            Console.WriteLine("Первый массив : ");
            foreach (int i in mass1)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n Второй массив : ");
            foreach (int i in mass2)
            {
                Console.Write(i + " ");
            }

            int[] array_all = MergeSort(mass1, mass2);
            Console.WriteLine("\n Массив после слияния: ");
            foreach (int k in array_all)
            {
                Console.Write(k + " ");
            }
        }

        private static int[] MergeSort(int[] mass1, int[] mass2)
        {
            int[] res = new int[mass1.Length + mass2.Length];
            int n = 0;
            int m = 0;
            for (int i = 0; i < res.Length; i++)
            {
                if (n < mass1.Length && m < mass2.Length)
                {
                    if (mass2[m] < mass1[n])
                    {
                        res[i] = mass2[m];
                        m++;
                    }
                    else
                    {
                        res[i] = mass1[n];
                        n++;
                    }
                }
                else
                {
                    if (n < mass1.Length)
                    {
                        for (; n < mass1.Length; n++, i++) res[i] = mass1[n];
                    }

                    if (m < mass2.Length)
                    {
                        for (; m < mass2.Length; m++, i++) res[i] = mass2[m];
                    }
                }
            }
            return res;
        }
    }
}