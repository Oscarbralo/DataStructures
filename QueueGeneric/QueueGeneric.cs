namespace Queue
{
    public class QueueGeneric<T>
    {
        T empty;
        private Node<T> first;
        private Node<T> tail;
        private int numberOfNodes = 0;

        public class Node<T>
        {
            public T item;
            public Node<T> next;

            public Node(T element)
            {
                item = element;
                next = null;
            }
        }

        public void Enqueue(T element)
        {
            Node<T> newNode = new Node<T>(element);
            if (first == null)
            {
                first = newNode;
                first.next = tail;
                tail = first;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
            numberOfNodes++;
        }

        public T Dequeue()
        {
            if (!IsEmpty())
            {
                T item = first.item;
                first = first.next;
                numberOfNodes--;
                return item;
            }
            return empty;
        }

        public bool IsEmpty()
        {
            return numberOfNodes == 0;
        }

        public int StillInQueue()
        {
            return numberOfNodes;
        }
    }
}
