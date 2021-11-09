using System;

namespace Task_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyStack<Int32> stack = new MyStack<int>();
            stack.Push(7);
            stack.Push(6);
            foreach (int i in stack)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(Environment.NewLine + stack.Pop());
            MyQueue<String> queue = new MyQueue<string>();
            queue.Enqueue("Hello");
            queue.Enqueue("World");
            foreach (string s in queue)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine(Environment.NewLine + queue.Dequeue());
            
        }
    }
}