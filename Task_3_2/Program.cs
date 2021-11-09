using System;
using System.Collections.Generic;

namespace Task_3_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Int32> list1 = new List<int>();
            list1.AddRange(new int[] {3, 4, 5, 6});
            List<Int32> list2 = new List<int>();
            list2.AddRange(new int[] {5, 4, 2, 1});

            List<Int32> list = MyList<Int32>.getMyList1(list1, list2);
            foreach (Int32 i in list)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            list = MyList<Int32>.getMyList2(list1, list2);
            foreach (Int32 i in list)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            list = MyList<Int32>.getMyList3(list1, list2);
            foreach (Int32 i in list)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            list = MyList<Int32>.getMyList4(list1, list2);
            foreach (Int32 i in list)
            {
                Console.Write(i + " ");
            }
        }
    }
}