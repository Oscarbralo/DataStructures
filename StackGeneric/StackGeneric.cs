namespace Stack
{
    public class StackGeneric<T>
    {
        private T empty;
        private Node<T> first = null;
        int numberOfNodes = 0;

        private class Node<T>
        {
            public T item;
            public Node<T> next;

            public Node(T element)
            {
                item = element;
            }
        }

        public void Push(T element)
        {
            Node<T> newNode = new Node<T>(element);
            Node<T> oldFirst = first;
            if (oldFirst == null)
            {
                first = newNode;
                oldFirst = first;
            }
            else
            {
                oldFirst = first;
                first = newNode;
                first.next = oldFirst;

            }
            numberOfNodes++;
        }

        public T Pop()
        {
            if (first != null)
            {
                T result = first.item;
                first = first.next;
                return result;
            }
            return empty;
        }

        public bool IsEmpty()
        {
            return first == null;
        }

        public int CountElements()
        {
            return numberOfNodes;
        }
    }
}
