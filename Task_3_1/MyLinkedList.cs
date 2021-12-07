using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_3_1
{
    public class MyLinkedList<T> : IEnumerable<T>
    {
        private Node<T> head;
        private Node<T> currNode;
        private int count = 0;
        private int currNodeIndex = 0;

        public MyLinkedList()
        {
        }
        public MyLinkedList(T value)
        {
            this.currNode = new Node<T>(value);
            this.head = this.currNode;
            this.count = 1;
        }

        public T GetValue()
        {
            return currNode.Value;
        }

        public void AddNode(T value)
        {
            Node<T> temp = head;
            currNode = new Node<T>(value);
            currNode.NextNode = temp;
            currNode.NextNode.PrevNode = currNode;
            this.head = this.currNode;
            this.count++;
            this.currNodeIndex = 0;
        }

        public void PrevNode()
        {
            if (currNode.PrevNode != null)
            {
                currNode = currNode.PrevNode;
                currNodeIndex--;
                return;
            }
            throw new Exception("Не существует");
        }

        public void NextNode()
        {
            if (currNode.NextNode != null)
            {
                currNode = currNode.NextNode;
                currNodeIndex++;
                return;
            }

            throw new Exception("Не существует");
        }

        public bool isEmpty()
        {
            return count == 0;
        }

        public void replaceItem(T e1, T e2)
        {
            MyLinkedList<T> tt = this;
            tt.currNode = tt.head;
            for (int i = 0; i < this.count; i++)
            {
                if (Equals(tt.GetValue(), e1)) tt.currNode.Value = e2;
                tt.NextNode();
            }
        }

        public void replaceLast()
        {
            MyLinkedList<T> tt = this;
            tt.currNode = tt.head;
            T temp = tt.GetValue();
            for (int i = 0; i < this.count; i++)
            {
                tt.NextNode();
            }

            T temp2 = tt.GetValue();
            tt.currNode.Value = temp;
            tt.NextNode();
            tt.currNode.Value = temp2;
        }

        public void setHead()
        {
            this.currNode = this.head;
            this.currNodeIndex = 0;
        }

        public double srArf()
        {
            double sum = 0;
            try
            {
                MyLinkedList<T> temp = this;
                temp.setHead();
                for (int i = 0; i < temp.count; i++)
                {
                    sum += Convert.ToDouble(temp.GetValue());
                }

                return sum / temp.count;
            }
            catch
            {
                Console.WriteLine("Not number");
                return 0;
            }
        }

        public int getLastSum()
        {
            MyLinkedList<T> temp = this;
            temp.setHead();
            for (int i = 0; i < count - 1; i++)
            {
                temp.NextNode();
            }

            try
            {
                int one = Convert.ToInt32(temp.GetValue());
                temp.NextNode();
                return one + Convert.ToInt32(temp.GetValue());
            }
            catch
            {
                Console.WriteLine("Not number");
                return 0;
            }
        }

        public bool isOrdered()
        {
            MyLinkedList<T> temp = this;
            try
            {
                double last = Convert.ToDouble(temp.GetValue());
                bool up = true;
                temp.NextNode();
                if (last < Convert.ToDouble(temp.GetValue())) up = false;
                for (int i = 0; i < count-1; i++)
                {
                    last = Convert.ToDouble(temp.GetValue());
                    NextNode();
                    if (up)
                    {
                        if (last < Convert.ToDouble(temp.GetValue())) return false;
                    }
                    else if (last > Convert.ToDouble(temp.GetValue())) return false;
                }
                last = Convert.ToDouble(temp.GetValue());
                NextNode();
                if (up)
                {
                    if (last < Convert.ToDouble(temp.GetValue())) return false;
                }
                else if (last > Convert.ToDouble(temp.GetValue())) return false;

                return true;
            }
            catch
            {
                Console.WriteLine("Not number");
                return false;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}