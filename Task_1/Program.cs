using System;

namespace Task_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[10];
            var rnd = new Random();
            Console.WriteLine("Неотсортированный массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-100, 100);
                Console.Write(arr[i] + " ");
            }
            int[] temp = SelectionSort(arr);
            Console.WriteLine("Отсортированный массив методом выбора: ");
            foreach (var t in temp)
            {
                Console.Write(t + " ");
            }
            temp = BubbleSort(arr);
            Console.WriteLine("Отсортированный массив методом пузырька: ");
            foreach (var t in temp)
            {
                Console.Write(t + " ");
            }
            temp = InsertionSort(arr);
            Console.WriteLine("Отсортированный массив методом вставки: ");
            foreach (var t in temp)
            {
                Console.Write(t + " ");
            }
            Console.WriteLine();
            foreach (var t in arr)
            {
                Console.Write(t + " ");
            }
            Console.ReadKey();
        }

        private static int[] SelectionSort(int[] mass)
        {
            int count = 0;
            int[] temp = (int[]) mass.Clone();
            for (int i = 0; i < temp.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < temp.Length; j++)
                {
                    if (temp[j] < temp[min])
                    {
                        min = j;
                    }
                }

                Swap(ref temp[min], ref temp[i]);
                count += 5;
            }
            Console.WriteLine("\n\n Количество операций в методе выбора: " + count);
            return temp;
        }

        private static int[] BubbleSort(int[] mass)
        {
            int[] tempMass = (int[]) mass.Clone();
            int count = 0;
            for (int i = 0; i < tempMass.Length; i++)
            {
                for (int j = i + 1; j < tempMass.Length; j++)
                {
                    if (tempMass[i] > tempMass[j])
                    {
                        Swap(ref tempMass[i],ref tempMass[j]);
                    }
                    count += 4;
                }
            }
            Console.WriteLine("\n\n Количество операций в методе пузырька: " + count);
            return tempMass;
        }

        private static int[] InsertionSort(int[] mass)
        {
            int count = 0;
            int[] tempMass = (int[]) mass.Clone();
            for (int i = 1; i < tempMass.Length; i++)
            {
                var x = tempMass[i];
                var j = i;
                while (j > 0 && tempMass[j - 1] > x)
                {
                    Swap(ref tempMass[j], ref tempMass[j - 1]);
                    j -= 1;
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