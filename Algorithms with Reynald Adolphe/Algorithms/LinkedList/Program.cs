using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.InsertFirst(100);
            singlyLinkedList.InsertFirst(50);
            singlyLinkedList.InsertFirst(19);
            singlyLinkedList.InsertFirst(89);

            singlyLinkedList.InsertLast(100000);
            singlyLinkedList.InsertLast(77);

            singlyLinkedList.DisplayList();

            singlyLinkedList.DeleteFirst();
            singlyLinkedList.DisplayList();
        }
    }

    public class Node
    {
        public int data;
        public Node next;

        public void DisplayNode()
        {
            Console.WriteLine("<" + data + ">");
        }
    }

    public class SinglyLinkedList 
    {
        private Node first;

        public bool IsEmpty()
        {
            return (first == null);
        }

        public void InsertFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = first;
            first = newNode;
        }

        public Node DeleteFirst()
        {
            Node temp = first;
            first = first.next;
            return temp;
        }

        public void DisplayList()
        {
            Console.WriteLine("List (first -- last) ");
            
            Node current = first;

            while (current != null)
            {
                current.DisplayNode();
                current = current.next;
            }

            Console.WriteLine();
        }

        public void InsertLast(int data)
        {
            Node current = first;

            while (current.next != null)
            {
                current = current.next;
            }

            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;
        }
    }
}
