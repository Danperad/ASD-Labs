﻿using System;

namespace Task_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList<int> r = new LinkedList<int>(5);
            for (int i = 4; i >= 0; i--)
            {
                r.addNode(i);
            }

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(r.getValue());
                r.nextNode();
            }
        }
    }
}