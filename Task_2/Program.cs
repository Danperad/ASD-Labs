using System;

namespace Task_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите значение для нахождения близжайшего по недостатку числа Фибоначи: ");
            long x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Близжайшее число Фибоначи к {x}: " + Fibanachi(x));
        }
        
        private static long Fibanachi(long x, long index = 2, long f = 1)
        {
            if (f >= x) return Fib(index - 1);
            index++;
            f = Fib(index);
            return Fibanachi(x, index, f);
        }
        private static long Fib(long x, long a = 1)
        {
            if (x < 3) return 1;
            x--;
            return Fib(x, a) + Fib(x - 1, a);
        }
    }
}