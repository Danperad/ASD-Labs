using System;

namespace Task_3_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            MyLinkedList<int> r = new MyLinkedList<int>(5);
            for (int i = 4; i >= 0; i--)
            {
                r.AddNode(i);
            }

            bool key = true;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(r.GetValue());
                try
                {
                    if(key) r.NextNode();
                    else r.PrevNode();
                }
                catch (Exception e)
                {
                    key = !key;
                    if(key) r.NextNode();
                    else r.PrevNode();
                }
            }
        }
    }
}