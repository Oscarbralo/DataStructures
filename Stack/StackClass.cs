namespace Stack
{
    public class StackClass
    {
        private Node first = null;
        int numberOfNodes = 0;

        private class Node
        {
            public string item;
            public Node next;

            public Node(string element)
            {
                item = element;
            }
        }

        public void Push(string element)
        {
            Node newNode = new Node(element);
            Node oldFirst = first;
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

        public string Pop()
        {
            if (first != null)
            {
                string result = first.item;
                first = first.next;
                return result;
            }
            return "No more elements in the stack";
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
