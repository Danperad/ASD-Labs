using System;

namespace Task_3_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MySortedList L1 = new MySortedList();
            L1.add(3.0);
            L1.add(2.0);
            MySortedList L2 = new MySortedList();
            L2.add(4.0);
            L2.add(2.0);

            MySortedList list = MySortedList.getNewList(L1, L2);
            foreach (double d in list)
            {
                Console.Write(d + " ");
            }

        }
    }
}