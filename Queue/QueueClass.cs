using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class QueueClass
    {
        private Node first;
        private Node tail;
        private int numberOfNodes = 0;

        public class Node
        {
            public string item;
            public Node next;

            public Node(string element)
            {
                item = element;
                next = null;
            }
        }

        public void Enqueue(string element)
        {
            Node newNode = new Node(element);
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

        public string Dequeue()
        {
            if (!IsEmpty())
            {
                string item = first.item;
                first = first.next;
                numberOfNodes--;
                return item;
            }
            else
            {
                return "No more elements in the queue";
            }
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
