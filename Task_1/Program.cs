﻿using System;

namespace Task_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"Наибольший общий делитель {a}, {b} и {c} = " + Nod(Nod(a, b), c));
        }

        private static int Nod(int a, int b)
        {
            if (a == 0) return b;
            if (b == 0) return a;
            if (a > b) return Nod(b, a % b);
            if (a < b) return Nod(a, b % a);
            if (a == b) return a;
            return 1;
        }
    }
}