using System;

namespace LinkedListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<string> n = new Node<string>("Mario");
            n.tailAdd("Sonia");
            n.tailAdd("Oscar");
            n.printList(n.getHead());
            n.printHead();
            n.printTail();
            n.totalNodes();
            Console.ReadLine();
        }
    }

    class Node<T>
    {
        Node<T> next = null;
        T data;
        Node<T> head;
        Node<T> tail;

        public Node()
        {

        }

        public Node(T d)
        {
            data = d;
        }

        public void tailAdd(T d)
        {
            Node<T> t = new Node<T>(d);
            if (tail != null)
            {
                tail.next = t;
                tail = t;
            }
            else
            {
                tail = this;
                head = this;
                next = t;
                tail = t;
            }
        }

        public Node<T> getHead()
        {
            return head;
        }

        public Node<T> getTail()
        {
            return tail;
        }

        public void printHead()
        {
            if (head != null)
                Console.WriteLine("Head: {0}", head.data);
            else
                Console.WriteLine("This list have no head and tail");
        }

        public void printTail()
        {
            if (head != null)
                Console.WriteLine("Tail: {0}", tail.data);
        }

        public void printList(Node<T> n)
        {
            Console.WriteLine("Here the list");
            while (n.next != null)
            {
                Console.WriteLine(n.data);
                n = n.next;
            }
            Console.WriteLine(n.data + "\n");
        }

        public void totalNodes()
        {
            if (head != null)
                totalNodes(head);
            else
                Console.WriteLine("No nodes in this list");
        }

        public void totalNodes(Node<T> head)
        {
            int count = 0;
            while (head != null)
            {
                count++;
                head = head.next;
            }
            Console.WriteLine("Number of nodes: {0}", count);
        }
    }
}