using System;

namespace Task_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            var rnd = new Random();
            int x = 13;
            int[] array = new int[x];
            for (int i = 0; i < x; i++)
                array[i] = rnd.Next(0, 100);
            Console.WriteLine("Исходный массив: ");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            var temp = HoarSort(array);
            Console.WriteLine("\n Отсортированный массив методом Хоара: ");
            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
        }
        private static int[] HoarSort(int[] mass, int left = 0, int right = -1)
        {
            int[] temp = (int[]) mass.Clone();
            if (right == -1)
            {
                right = temp.Length;
            }
            int spin = (right + left) / 2;
            if (right - left < 2) return temp;
            int x1;
            int x2;
            do
            {
                x1 = spin;
                x2 = spin;
                for (int i = left; i < spin; i++)
                {
                    if (temp[i] > temp[x1])
                    {
                        x1 = i;
                        break;
                    }
                }
                for (int i = spin; i < right; i++)
                {
                    if (temp[i] < temp[x2])
                    {
                        x2 = i;
                        break;
                    }
                }
                Swap(ref temp[x1], ref temp[x2]);
            } while (x1 != x2);
            temp = HoarSort(temp, left, spin);
            temp = HoarSort(temp, spin + 1, right);
            return temp;
        }
        private static void Swap(ref int x, ref int y)
        {
            (x, y) = (y, x);
        }
    }
}