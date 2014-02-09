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
            n.printListReverse(n.getTail());
            n.printHead();
            n.printTail();
            n.totalNodes();
            Console.ReadLine();
        }
    }

    class Node<T>
    {
        Node<T> next = null;
        Node<T> previous = null;
        T data;
        Node<T> head = null;
        Node<T> tail = null;

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
                t.previous = tail;
                tail = t;
            }
            else
            {
                tail = this;
                head = this;
                t.previous = tail;
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

        public void printListReverse(Node<T> n)
        {
            n = tail;
            Console.WriteLine("Here the reverse list");
            while (n.previous != null)
            {
                Console.WriteLine(n.data);
                n = n.previous;
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

        public void totalNodes(Node<T> n)
        {
            int count = 0;
            while (n != null)
            {
                count++;
                n = n.next;
            }
            Console.WriteLine("Number of nodes: {0}", count);
        }
    }
}