using System;

namespace Task_9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = new int[10];
            Console.WriteLine("Неотсортированный массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-100, 100);
                Console.Write(arr[i] + " ");
            }

            var temp = ShellSort(arr);
            Console.WriteLine("\n Отсортированный массив: ");
            foreach (var t in temp)
            {
                Console.Write(t + " ");
            }

            Console.ReadKey();
        }
        
        private static int[] ShellSort(int[] mass)
        {
            int i, j, step;
            int[] temp = (int[]) mass.Clone();
            int tmp;
            for (step = temp.Length / 2; step > 0; step /= 2)
            {
                for (i = step; i < temp.Length; i++)
                {
                    tmp = temp[i];
                    for (j = i; j >= step; j -= step)
                    {
                        if (tmp < temp[j - step])
                            temp[j] = temp[j - step];
                        else
                            break;
                    }
                    temp[j] = tmp;
                }
            }

            return temp;
        }
    }
}