namespace Task_3
{
    public class Node<T>
    {
        private T _value;
        private Node<T> _node;

        public Node(T value)
        {
            this._value = value;
        }
        public T Value
        {
            get => _value;
            set => _value = value;
        }

        public Node<T> nextNode
        {
            get => _node;
            set => _node = value;
        }
    }
}