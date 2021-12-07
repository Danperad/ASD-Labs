using System;

namespace Task_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите исходное число в десятичной системе : ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите систему счисления : ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Перевод из 10-ой в {size} систему счисления: {Translation(x, size)}");
            Console.ReadKey();
        }
        
        private static string Translation(int x, int size, string str = " ")
        {
            str = x % size + str;
            if (x / size < size)
            {
                return x / size + str;
            }
            return Translation(x / size, size, str);
        }
    }
}