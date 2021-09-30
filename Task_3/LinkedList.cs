using System;

namespace Task_3
{
    public class LinkedList<T>
    {
        private Node<T> head;
        private Node<T> currNode;
        private int count;
        private int currNodeIndex = 0;

        public LinkedList(T value)
        {
            this.currNode = new Node<T>(value);
            this.head = this.currNode;
            this.count = 1;
        }

        public T getValue()
        {
            return currNode.Value;
        }

        public void addNode(T value)
        {
            Node<T> temp = head;
            currNode = new Node<T>(value);
            currNode.nextNode = temp;
            this.head = this.currNode;
            this.count++;
            this.currNodeIndex = 0;
        }

        public void nextNode()
        {
            if (currNode.nextNode != null)
            {
                currNode = currNode.nextNode;
                currNodeIndex++;
                return;
            }

            currNode = head;
            currNodeIndex = 0;
        }

        public bool isEmpty()
        {
            return count == 0;
        }

        public void replaceItem(T e1, T e2)
        {
            LinkedList<T> tt = this;
            tt.currNode = tt.head;
            for (int i = 0; i < this.count; i++)
            {
                if (Equals(tt.getValue(), e1)) tt.currNode.Value = e2;
                tt.nextNode();
            }
        }

        public void replaceLast()
        {
            LinkedList<T> tt = this;
            tt.currNode = tt.head;
            T temp = tt.getValue();
            for (int i = 0; i < this.count; i++)
            {
                tt.nextNode();
            }

            T temp2 = tt.getValue();
            tt.currNode.Value = temp;
            tt.nextNode();
            tt.currNode.Value = temp2;
        }

        public void setHead()
        {
            this.currNode = this.head;
            this.currNodeIndex = 0;
        }

        public double? srArf()
        {
            double sum = 0;
            try
            {
                LinkedList<T> temp = this;
                temp.setHead();
                for (int i = 0; i < temp.count; i++)
                {
                    sum+= Convert.ToDouble(temp.getValue());
                }

                return sum / temp.count;
            }
            catch
            {
                return null;
            }
        }

        public int getLastSum()
        {
            LinkedList<T> temp = this;
            temp.setHead();
            for (int i = 0; i < count-1; i++)
            {
                temp.nextNode();
            }

            int one = Convert.ToInt32(temp.getValue());
            temp.nextNode();
            return one + Convert.ToInt32(temp.getValue());
        }
    }
}