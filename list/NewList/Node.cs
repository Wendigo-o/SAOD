namespace NewList
{
    internal class Node<T>
    {
        public T value;
        public Node(T val)
        {
            value = val;
        }
        public Node<T> next;
        public Node<T> previous;
    }
}