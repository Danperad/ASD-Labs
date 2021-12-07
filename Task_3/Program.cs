using System;

namespace Task_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int result = NOD(x, y);
            
            Console.WriteLine("НОД " + x + " и "+ y + " = " + result);
            Console.ReadLine();
        }

        private static int NOD(int int1, int int2)
        {
            if (int1 == int2) return int1;
            int temp = 1;
            while (int1 != int2)
            {
                if (int1 > int2)
                {
                    temp = int1 - int2;
                    int1 -= int2;
                }
                else if (int1 < int2)
                {
                    temp = int2 - int1;
                    int2 -= int1;
                }
            }

            return temp;
        }
    }
}